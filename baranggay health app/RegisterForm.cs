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
    public partial class RegisterForm: Form
    {
        
        public RegisterForm()
        {
            InitializeComponent();
           
        }

        private void register_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) ||
                string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(labelgfg.Text)) // Added Gender Validation
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse Age
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Invalid Age. Please enter a number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected gender
            string gender = cmbGender.SelectedItem.ToString();

            // Call DatabaseHelper to insert user
            string message;
            bool isRegistered = DatabaseHelper.RegisterUser(
                txtFirstname.Text, txtMiddlename.Text, txtLastname.Text, age,
                dtpDateOfBirth.Value.Date, gender, txtContactNumber.Text, txtLocation.Text,
                txtUsername.Text, txtPassword.Text, txtEmail.Text, out message
            );

            if (isRegistered)
            {
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide(); // Close Register Form
                login loginForm = new login(); // Reopen Login Form
                loginForm.Show();
            }
            else
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            login loginform = new login();
            loginform.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }
    }
}
