using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class uc_Librarians : UserControl
    {
        private FormMain mainForm;

        public uc_Librarians(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void saveLibrarianBtn_Click(object sender, EventArgs e)
        {
            string firstName = librarianFNtb.Text.Trim();
            string lastName = librarianLNtb.Text.Trim();
            string email = librarianEmailtb.Text.Trim();
            string username = librarianUNtb.Text.Trim();
            string password = librarianPasstb.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            long addedBy = Session.LoggedInUserID;

            using (SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = @"
            INSERT INTO Librarians (Username, PasswordHash, FirstName, LastName, Email, AddedByUserID)
            VALUES (@Username, @PasswordHash, @FirstName, @LastName, @Email, @AddedByUserID)";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashedPassword);
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@AddedByUserID", addedBy);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Librarian added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect to UserLibrarians UC
                    FormMain mainForm = (FormMain)this.TopLevelControl;
                    uc_userLibrarians librariansUC = new uc_userLibrarians(mainForm);
                    mainForm.SwitchUserControl(librariansUC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void discardLibrarianBtn_Click(object sender, EventArgs e)
        {
            uc_userLibrarians librariansControl = new uc_userLibrarians(mainForm);
            mainForm.SwitchUserControl(librariansControl);
        }
    }
}
