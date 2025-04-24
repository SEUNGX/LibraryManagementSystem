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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        // Set form opacity when it loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        // Add rounded, transparent panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Set a semi-transparent background for the panel (RGBA with alpha = 120 for transparency)
            var color = Color.FromArgb(120, 255, 255, 255); // RGBA with transparency (alpha = 120)
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }

            // Draw a rounded border
            var borderColor = Color.Gray; // Border color
            var borderWidth = 3; // Border width
            var borderRadius = 20; // Border radius for rounded corners

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // Create a rounded rectangle path
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawArc(pen, new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Top left
                e.Graphics.DrawArc(pen, new Rectangle(panel1.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Top right
                e.Graphics.DrawArc(pen, new Rectangle(0, panel1.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bottom left
                e.Graphics.DrawArc(pen, new Rectangle(panel1.Width - borderRadius, panel1.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bottom right
                e.Graphics.DrawLine(pen, borderRadius, 0, panel1.Width - borderRadius, 0); // Top side
                e.Graphics.DrawLine(pen, 0, borderRadius, 0, panel1.Height - borderRadius); // Left side
                e.Graphics.DrawLine(pen, 0, panel1.Height - borderRadius, panel1.Width, panel1.Height - borderRadius); // Bottom side
                e.Graphics.DrawLine(pen, panel1.Width - borderRadius, 0, panel1.Width - borderRadius, panel1.Height); // Right side
            }
        }






        //private void btnLogin_Click(object sender, EventArgs e)
        //{
        //    this.DialogResult = DialogResult.OK; // Signal that login was successful
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True;"))
            {
                string query = "SELECT UserID, PasswordHash FROM Librarians WHERE Username = @Username AND IsActive = 1";
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                long userId = reader.GetInt64(0);
                                string storedHash = reader.GetString(1);

                                if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                                {
                                    // Store the user session info
                                    Session.LoggedInUserID = userId;
                                    Session.Username = username;

                                    this.DialogResult = DialogResult.OK; // success
                                    return;
                                }
                            }
                        }

                        MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during login: " + ex.Message);
                }
            }
        }

    }
}
