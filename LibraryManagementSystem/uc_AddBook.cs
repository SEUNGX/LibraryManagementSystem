using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class uc_AddBook : UserControl
    {
        FormMain mainForm;

        public uc_AddBook(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void uc_AddBook_Load(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper();

            // Load authors into the author combo box
            var authors = dbHelper.GetAllAuthorNames();
            authorCb.Items.Clear();
            authorCb.Items.AddRange(authors.ToArray());

            // Load categories into the category combo box (using strings)
            var categories = dbHelper.GetAllCategories();
            categoryCb.Items.Clear();
            categoryCb.Items.AddRange(categories.ToArray());

            // Optionally set a default selected index if desired
            if (categoryCb.Items.Count > 0)
            {
                categoryCb.SelectedIndex = 0;  // Automatically selects the first category
            }
        }




        //private void saveBookBtn_Click(object sender, EventArgs e)
        //{
        //    // Get data from textboxes and combo boxes
        //    string isbn = ISBNtb.Text.Trim();
        //    string title = titleTb.Text.Trim();
        //    string publisher = publisherTb.Text.Trim();
        //    int pubYear = 0; // Default value
        //    int.TryParse(pubYearTb.Text.Trim(), out pubYear); // Try parsing to integer
        //    string edition = editionTb.Text.Trim();
        //    string author = authorCb.SelectedItem.ToString(); // Get selected author
        //    int totalCopies = 0; // Default value
        //    int.TryParse(totalCopiesTb.Text.Trim(), out totalCopies); // Try parsing to integer
        //    string description = descriptionTb.Text.Trim();
        //    long categoryId = (categoryCb.SelectedItem as dynamic).CategoryID; // Assuming categoryCb is a list of category objects with CategoryID
        //    long currentUserId = Session.LoggedInUserID; // Replace this with the actual logged-in user ID

        //    // Validation
        //    if (string.IsNullOrEmpty(isbn) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(publisher) || pubYear == 0 || string.IsNullOrEmpty(edition) || totalCopies == 0 || categoryId == 0)
        //    {
        //        MessageBox.Show("All fields must be filled.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        // Save to the database
        //        DatabaseHelper dbHelper = new DatabaseHelper();
        //        dbHelper.InsertBook(isbn, title, publisher, pubYear, edition, author, categoryId, totalCopies, description, currentUserId);

        //        // Show success message
        //        MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // Redirect to ucBooks
        //        ucBooks booksControl = new ucBooks(mainForm);
        //        mainForm.SwitchUserControl(booksControl);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Error handling
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void saveBookBtn_Click(object sender, EventArgs e)
        {
            // Basic null/empty checks first
            if (string.IsNullOrWhiteSpace(ISBNtb.Text) ||
                string.IsNullOrWhiteSpace(titleTb.Text) ||
                string.IsNullOrWhiteSpace(publisherTb.Text) ||
                string.IsNullOrWhiteSpace(pubYearTb.Text) ||
                string.IsNullOrWhiteSpace(editionTb.Text) ||
                authorCb.SelectedItem == null ||
                categoryCb.SelectedItem == null ||
                string.IsNullOrWhiteSpace(totalCopiesTb.Text) ||
                string.IsNullOrWhiteSpace(descriptionTb.Text))
            {
                MessageBox.Show("All fields are required!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get values
            string isbn = ISBNtb.Text.Trim();
            string title = titleTb.Text.Trim();
            string publisher = publisherTb.Text.Trim();
            int pubYear = int.TryParse(pubYearTb.Text.Trim(), out pubYear) ? pubYear : 0;
            string edition = editionTb.Text.Trim();
            string author = authorCb.SelectedItem.ToString();
            string categoryName = categoryCb.SelectedItem.ToString();
            int totalCopies = int.TryParse(totalCopiesTb.Text.Trim(), out totalCopies) ? totalCopies : 1;
            string description = descriptionTb.Text.Trim();
            long currentUserId = Session.LoggedInUserID; // Replace this with actual logged-in user ID

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                long selectedAuthorID = dbHelper.GetAuthorIDByName(author);
                long categoryID = dbHelper.GetCategoryIdByName(categoryName);

                // Final ID checks
                if (selectedAuthorID == 0 || categoryID == 0)
                {
                    MessageBox.Show("Invalid author or category selected!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dbHelper.InsertBook(isbn, title, selectedAuthorID, publisher, pubYear, edition, categoryID, totalCopies, description, currentUserId);
                MessageBox.Show("Book saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ucBooks booksControl = new ucBooks(mainForm);
                mainForm.SwitchUserControl(booksControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void discardBookBtn_Click(object sender, EventArgs e)
        {
            ucBooks booksControl = new ucBooks(mainForm);
            mainForm.SwitchUserControl(booksControl);
        }
    }
}
