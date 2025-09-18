using baranggay_health_app.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace baranggay_health_app
{
    public partial class AppointmentForm : Form
    {
        public AppointmentForm()
        {
            InitializeComponent();
            cbFilterPurpose.SelectedIndexChanged += cbFilterPurpose_SelectedIndexChanged;
            cbFilterPurpose.Items.AddRange(new string[] { "All", "General Check Up", "Vaccine", "Prenatal Check Up" });
            cbFilterPurpose.SelectedIndex = 0; // Default selection
            UpdateTotalPatientsLabel();

        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();  // Load appointments when the form loads
        }
        private void FilterAppointmentsByPurpose(string purpose)
        {
            try
            {
                DataTable appointments = AppointmentData.GetAppointments();

                if (purpose == "All")
                {
                    dgvAppointments.DataSource = appointments;
                    UpdateTotalPatientsLabel();
                }
                else
                {
                    var filteredAppointments = appointments.AsEnumerable()
                        .Where(row => row.Field<string>("Purpose").Equals(purpose, StringComparison.OrdinalIgnoreCase))
                        .ToList();

                    if (filteredAppointments.Any())
                    {
                        DataTable filteredTable = filteredAppointments.CopyToDataTable();
                        dgvAppointments.DataSource = filteredTable;
                        UpdateTotalPatientsLabel();
                    }
                    else
                    {
                        dgvAppointments.DataSource = null;
                        MessageBox.Show("No appointments found for selected purpose.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering appointments: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateTotalPatientsLabel()
        {
            int total = dgvAppointments.Rows.Count;

            // Check if the last row is a new row (for adding data) and reduce count
            if (dgvAppointments.AllowUserToAddRows && dgvAppointments.Rows[total - 1].IsNewRow)
            {
                total -= 1;
            }

            lblTotalPatients.Text = $"Total Patients: {total}";
        }

        private void cbFilterPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPurpose = cbFilterPurpose.SelectedItem.ToString();
            FilterAppointmentsByPurpose(selectedPurpose);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(PatientName.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtGuardian.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) || cbPurpose.SelectedItem == null ||
                    cbDoctor.SelectedItem == null || cbSex.SelectedItem == null || dptbirthdate.Value == null)
                {
                    MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string message;
                bool isAdded = DatabaseHelper.AddAppointment(
                    PatientName.Text,

                    dptbirthdate.Value.Date,
                    int.Parse(txtAge.Text),
                    cbSex.SelectedItem.ToString(), // Get selected gender from ComboBox
                    cbPurpose.SelectedItem.ToString(),
                    cbDoctor.SelectedItem.ToString(),
                    schedule.Value.ToString("yyyy-MM-dd"),
                    txtGuardian.Text,
                    txtContactNumber.Text,
                    txtAddress.Text,
                    int.Parse(doctorid.Text),
                    out message);

                if (isAdded)
                {
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string messages;
                bool isAddeds = DatabaseHelper.insertPatient(PatientName.Text, dptbirthdate.Value.Date, int.Parse(txtAge.Text),
                      cbSex.SelectedItem.ToString(), // Get selected gender from ComboBox
                      cbPurpose.SelectedItem.ToString(),
                     schedule.Value.ToString("yyyy-MM-dd"), txtGuardian.Text, txtContactNumber.Text, txtAddress.Text, out messages);
                if (isAddeds)
                {
                    MessageBox.Show(messages, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(messages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                AppointmentForm appointment = new AppointmentForm();
                appointment.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                // Catch any exceptions that occur during the process
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            dgvAppointments.DataSource = AppointmentData.GetAppointments(); // Load data

            // Make sure id_app is visible but readonly
            dgvAppointments.Columns["IdApp"].HeaderText = "Appointment ID";
            dgvAppointments.Columns["IdApp"].ReadOnly = true;
        }

        private void Delete_BTN_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0)
            {
                int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells[0].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string message;
                    bool isDeleted = deletehandler.MoveToHistoryAndDelete(appointmentId, out message);

                    MessageBox.Show(message, isDeleted ? "Success" : "Error", MessageBoxButtons.OK, isDeleted ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (isDeleted)
                    {
                        LoadAppointments(); // Reload appointments after deletion
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void History_BTN_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
            this.Hide();
        }

        private void Doctors_BTN_Click(object sender, EventArgs e)
        {
            dgvAppointments.DataSource = DoctorData.GetDoctors();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentForm appointment = new AppointmentForm();
            appointment.Show();
        }

        // Doctor selection changed event handler
        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedItem != null)
            {
                string selectedDoctor = cbDoctor.SelectedItem.ToString();

                if (selectedDoctor.Equals("Jhony", StringComparison.OrdinalIgnoreCase))
                {
                    doctorid.Text = "10903";
                }
                else if (selectedDoctor.Equals("clark", StringComparison.OrdinalIgnoreCase))
                {
                    doctorid.Text = "10904";
                }
                else if (selectedDoctor.Equals("kath", StringComparison.OrdinalIgnoreCase))
                {
                    doctorid.Text = "10905";
                }
                else if (selectedDoctor.Equals("anna", StringComparison.OrdinalIgnoreCase))
                {
                    doctorid.Text = "10906";
                }
            }
        }

        // Search function when the search text changes
        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            SearchAppointments(searchtxt.Text);  // Call the search function
        }

        // Function to search for appointments based on the search query
        private void SearchAppointments(string searchQuery)
        {
            try
            {
                // If search query is empty, load all appointments
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    LoadAppointments();  // Reload all appointments if search box is cleared
                }
                else
                {

                    DataTable appointments = AppointmentData.GetAppointments();


                    var filteredAppointments = appointments.AsEnumerable()
                        .Where(row => /*row.Field<int>("IdApp").ToString().IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||*/
                        row.Field<string>("PatientName").IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0)
                        //row.Field<int>("Age").ToString().IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0 ||
                        //row.Field<string>("ContactNumber").IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) >= 0) // Add other filters here if needed
                        .ToList();


                    if (filteredAppointments.Any())
                    {

                        DataTable filteredDataTable = filteredAppointments.CopyToDataTable();
                        dgvAppointments.DataSource = filteredDataTable;
                        HighlightSearchResults(filteredDataTable, searchQuery);
                    }
                    else
                    {

                        MessageBox.Show("No results found matching the search criteria.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAppointments.DataSource = null;
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
            foreach (DataGridViewRow row in dgvAppointments.Rows)
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




        // Unused methods (keeping them as is)
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Timer tick event (currently unused)
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Panel2 paint event (currently unused)
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Panel1 paint event (currently unused)
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            // Panel2 (second instance) paint event (currently unused)
        }

        private void dgvAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridView cell content click event (currently unused)
        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvAppointments.SelectedRows.Count > 0)
                {
                    int appointmentId = Convert.ToInt32(dgvAppointments.SelectedRows[0].Cells["IdApp"].Value);

                    // Validate inputs
                    if (string.IsNullOrWhiteSpace(PatientName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) ||
                        string.IsNullOrWhiteSpace(txtGuardian.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                        string.IsNullOrWhiteSpace(txtAddress.Text) || cbPurpose.SelectedItem == null ||
                        cbDoctor.SelectedItem == null || cbSex.SelectedItem == null || dptbirthdate.Value == null)
                    {
                        MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string message;
                    bool isUpdated = DatabaseHelper.UpdateAppointment(
                        appointmentId,
                        PatientName.Text,
                        dptbirthdate.Value.Date,
                        int.Parse(txtAge.Text),
                        cbSex.SelectedItem.ToString(),
                        cbPurpose.SelectedItem.ToString(),
                        cbDoctor.SelectedItem.ToString(),
                        schedule.Value.ToString("yyyy-MM-dd"),
                        txtGuardian.Text,
                        txtContactNumber.Text,
                        txtAddress.Text,
                        int.Parse(doctorid.Text),
                        out message);

                    MessageBox.Show(message, isUpdated ? "Success" : "Error", MessageBoxButtons.OK, isUpdated ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                    if (isUpdated)
                    {
                        AppointmentForm appointment = new AppointmentForm();
                        appointment.Show();
                        this.Close();  // Refresh the DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Please select an appointment to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Check if a valid row is clicked
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];

                // Populate textboxes with values from the selected row
                PatientName.Text = row.Cells["PatientName"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();  // Assuming there's an Age column
                txtGuardian.Text = row.Cells["Guardian"].Value.ToString();  // Assuming there's a Guardian column
                txtContactNumber.Text = row.Cells["ContactNumber"].Value.ToString();  // Assuming there's a ContactNumber column
                txtAddress.Text = row.Cells["Address"].Value.ToString();  // Assuming there's an Address column
                cbPurpose.SelectedItem = row.Cells["Purpose"].Value.ToString();  // Assuming there's a Purpose column
                cbDoctor.SelectedItem = row.Cells["Doctor"].Value.ToString();  // Assuming there's a Doctor column
                cbSex.SelectedItem = row.Cells["Sex"].Value.ToString();  // Assuming there's a Sex column
                dptbirthdate.Value = DateTime.Parse(row.Cells["Birthdate"].Value.ToString());  // Assuming there's a Birthdate column
                schedule.Value = DateTime.Parse(row.Cells["Schedule"].Value.ToString());  // Assuming there's a Schedule column
                doctorid.Text = row.Cells["DoctorId"].Value.ToString();  // Assuming there's a DoctorId column
            }
        }
           
            
        


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)  // Make sure a valid row is clicked
            {
                DataGridViewRow row = dgvAppointments.Rows[e.RowIndex];

                // Get selected values
                string patientName = row.Cells["PatientName"].Value.ToString();
                string purpose = row.Cells["Purpose"].Value.ToString();
                string doctor = row.Cells["Doctor"].Value.ToString();
                string scheduleDate = DateTime.Parse(row.Cells["Schedule"].Value.ToString()).ToString("yyyy-MM-dd");

                // Confirm print
                DialogResult result = MessageBox.Show(
                    $"Do you want to generate a PDF for this appointment?\n\nPatient: {patientName}\nDoctor: {doctor}\nDate: {scheduleDate}",
                    "Confirm Print to PDF",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Appointment_{patientName}.pdf");

                    Document doc = new Document(PageSize.A4, 40f, 40f, 60f, 40f);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                        doc.Open();

                        // Fonts
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16f, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font bodyFont = FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.NORMAL);

                        // Title
                        Paragraph title = new Paragraph("Baranggay Health Appointment Receipt", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        doc.Add(title);

                        // Create table with 2 columns
                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;
                        table.SpacingBefore = 10f;
                        table.SpacingAfter = 10f;
                        table.DefaultCell.Padding = 8;

                        // Set column widths
                        float[] widths = { 1f, 2f };
                        table.SetWidths(widths);

                        // Add rows to the table
                        table.AddCell(new PdfPCell(new Phrase("Patient Name:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(patientName, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Purpose:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(purpose, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Doctor:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(doctor, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Schedule Date:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(scheduleDate, bodyFont)));

                        // Add Signature Row at the end of the table
                        table.AddCell(new PdfPCell(new Phrase("Signature:", headerFont)) { Colspan = 2, HorizontalAlignment = Element.ALIGN_LEFT, PaddingTop = 20f });

                        // Add table to document
                        doc.Add(table);

                        doc.Close();

                        MessageBox.Show($"PDF successfully created:\n{pdfPath}", "PDF Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            if (dgvAppointments.CurrentRow != null)  // Ensure a row is selected
            {
                DataGridViewRow row = dgvAppointments.CurrentRow;

                // Get selected values
                string patientName = row.Cells["PatientName"].Value.ToString();
                string purpose = row.Cells["Purpose"].Value.ToString();
                string doctor = row.Cells["Doctor"].Value.ToString();
                string scheduleDate = DateTime.Parse(row.Cells["Schedule"].Value.ToString()).ToString("yyyy-MM-dd");

                // Confirm print
                DialogResult result = MessageBox.Show(
                    $"Do you want to generate a PDF for this appointment?\n\nPatient: {patientName}\nDoctor: {doctor}\nDate: {scheduleDate}",
                    "Confirm Print to PDF",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Appointment_{patientName}.pdf");

                    Document doc = new Document(PageSize.A4, 40f, 40f, 60f, 40f);

                    try
                    {
                        PdfWriter.GetInstance(doc, new FileStream(pdfPath, FileMode.Create));
                        doc.Open();

                        // Fonts
                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 16f, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font headerFont = FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.BOLD);
                        iTextSharp.text.Font bodyFont = FontFactory.GetFont("Arial", 12f, iTextSharp.text.Font.NORMAL);

                        // Title
                        Paragraph title = new Paragraph("Baranggay Health Appointment Receipt", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 20f;
                        doc.Add(title);

                        // Create table
                        PdfPTable table = new PdfPTable(2);
                        table.WidthPercentage = 100;
                        table.SpacingBefore = 10f;
                        table.SpacingAfter = 10f;
                        table.DefaultCell.Padding = 8;

                        float[] widths = { 1f, 2f };
                        table.SetWidths(widths);

                        table.AddCell(new PdfPCell(new Phrase("Patient Name:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(patientName, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Purpose:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(purpose, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Doctor:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(doctor, bodyFont)));

                        table.AddCell(new PdfPCell(new Phrase("Schedule Date:", headerFont)));
                        table.AddCell(new PdfPCell(new Phrase(scheduleDate, bodyFont)));

                        // Signature
                        table.AddCell(new PdfPCell(new Phrase("Signature:", headerFont))
                        {
                            Colspan = 2,
                            HorizontalAlignment = Element.ALIGN_LEFT,
                            PaddingTop = 20f
                        });

                        doc.Add(table);
                        doc.Close();

                        MessageBox.Show($"PDF successfully created:\n{pdfPath}", "PDF Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error generating PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}