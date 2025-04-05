using System;
using System.Windows.Forms;
using BCrypt.Net;

namespace LibraryManagementSystem
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string firstName = tbfName.Text;
            string lastName = tblName.Text;
            string email = tbEmail.Text;
            string role = cbRole.SelectedItem?.ToString() ?? "";

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email))
                //string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // Hash password before storing
            string passwordHash = HashPassword(password);

            if (db.RegisterUser(username, passwordHash, firstName, lastName, email))
            {
                MessageBox.Show("User registered successfully!");
            }
            else
            {
                MessageBox.Show("Registration failed.");
            }
        }

        // Method to hash passwords
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Method to verify hashed password
        public bool VerifyPassword(string inputPassword, string storedHashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedHashedPassword);
        }
    }
}
