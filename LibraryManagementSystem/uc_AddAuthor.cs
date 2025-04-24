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
    public partial class uc_AddAuthor : UserControl
    {
        private FormMain mainForm;

        public uc_AddAuthor(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        //private void saveAuthorBtn_Click(object sender, EventArgs e)
        //{
        //    string firstName = authorFNtb.Text.Trim();
        //    string lastName = authorLNtb.Text.Trim();
        //    long currentUserId = 1; // Replace with actual user ID if needed

        //    if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        //    {
        //        MessageBox.Show("Both first and last name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        DatabaseHelper dbHelper = new DatabaseHelper();
        //        dbHelper.InsertAuthor(firstName, lastName, currentUserId);

        //        MessageBox.Show("Author saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Redirect to ucBooks
        //        ucBooks booksControl = new ucBooks(mainForm);
        //        mainForm.SwitchUserControl(booksControl);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void saveAuthorBtn_Click(object sender, EventArgs e)
        {
            string firstName = authorFNtb.Text.Trim();
            string lastName = authorLNtb.Text.Trim();
            long currentUserId = Session.LoggedInUserID; // ✅ Get from session

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Both first and last name are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.InsertAuthor(firstName, lastName, currentUserId); // ✅ Pass user ID

                MessageBox.Show("Author saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to ucBooks
                ucBooks booksControl = new ucBooks(mainForm);
                mainForm.SwitchUserControl(booksControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void discardAuthorBtn_Click(object sender, EventArgs e)
        {
            ucBooks booksControl = new ucBooks(mainForm);
            mainForm.SwitchUserControl(booksControl);
        }
    }
}
