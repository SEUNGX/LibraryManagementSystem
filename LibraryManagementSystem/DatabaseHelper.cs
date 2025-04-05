using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;
namespace LibraryManagementSystem
{
    public class DatabaseHelper
    {
        string connectionString = @"Server=.\SQLEXPRESS;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True;";


        public bool RegisterUser(string username, string passwordHash, string firstName, string lastName, string email)
        {


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Users (Username, PasswordHash, FirstName, LastName, Email) VALUES (@Username, @PasswordHash, @FirstName, @LastName, @Email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash); // Store hashed password
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        //cmd.Parameters.AddWithValue("@Role", role);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0; // Returns true if insertion is successful
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }

        public int GetTotalBooks()
        {
            int totalBooks = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Books";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        totalBooks = (int)cmd.ExecuteScalar(); // Get the count
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return totalBooks;
        }












    }
}
