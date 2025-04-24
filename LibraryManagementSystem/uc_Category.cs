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
    public partial class uc_Category : UserControl
    {
        FormMain mainForm;

        public uc_Category(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void saveCategoryBtn_Click(object sender, EventArgs e)
        {
            string categoryName = categoryTb.Text.Trim();
            string description = categoryDescriptionTb.Text.Trim();

            long currentUserId = Session.LoggedInUserID; // ✅ Use actual user ID

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Category name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                dbHelper.InsertCategory(categoryName, description, currentUserId); // ✅ Pass the user ID

                MessageBox.Show("Category saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirect to ucBooks after saving
                ucBooks booksControl = new ucBooks(mainForm);
                mainForm.SwitchUserControl(booksControl);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void discardCategoryBtn_Click(object sender, EventArgs e)
        {
            ucBooks booksControl = new ucBooks(mainForm);
            mainForm.SwitchUserControl(booksControl);
        }
    }
}
