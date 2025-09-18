using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baranggay_health_app
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
            this.Hide();
        }
        private void SearchHistory(string searchQuery)
        {
            try
            {
                // If search query is empty, load all appointments
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    dgvHistory.DataSource = HistoryData.GetHistory(); // Reload all appointments if search box is cleared
                }
                else
                {

                    DataTable history = HistoryData.GetHistory();


                    var filteredAppointments = history.AsEnumerable()
                        .Where(row => row.Field<int>("id").ToString().IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                        //row.Field<string>("PatientName").IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        //row.Field<int>("Age").ToString().IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        //row.Field<string>("ContactNumber").IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) // Add other filters here if needed
                        .ToList();


                    if (filteredAppointments.Any())
                    {

                        DataTable filteredDataTable = filteredAppointments.CopyToDataTable();
                        dgvHistory.DataSource = filteredDataTable;
                        HighlightSearchResults(filteredDataTable, searchQuery);
                    }
                    else
                    {

                        MessageBox.Show("No results found matching the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvHistory.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void HighlightSearchResults(DataTable filteredDataTable, string searchQuery)
        {
            foreach (DataGridViewRow row in dgvHistory.Rows)
            {
                bool matchFound = false;


                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        matchFound = true;
                        break;
                    }
                }


                if (matchFound)
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
            }
        }



        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dgvHistory.DataSource = HistoryData.GetHistory();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SearchHistory(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }


        private void dgvHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a row is clicked
            {
                int appointmentId = Convert.ToInt32(dgvHistory.Rows[e.RowIndex].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete this history record?",
                                                            "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string message;
                    bool isDeleted = deletehandler.DeleteHistoryRecord(appointmentId, out message); // Use a different method!

                    MessageBox.Show(message, isDeleted ? "Success" : "Error", MessageBoxButtons.OK,
                                    isDeleted ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (isDeleted)
                    {
                        dgvHistory.DataSource = HistoryData.GetHistory(); // Refresh the table
                    }
                }
            }
        }
    }
}

