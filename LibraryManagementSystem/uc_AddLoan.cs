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
    public partial class uc_AddLoan : UserControl
    {

        FormMain mainform;

        public uc_AddLoan(FormMain form)
        {
            InitializeComponent();
            mainform = form;
        }




        private void uc_AddLoan_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();

            // Fill member combo box
            loanMembercb.Items.Clear();
            var members = db.GetActiveMemberNames();
            foreach (string name in members)
            {
                loanMembercb.Items.Add(name);
            }

            // Fill book combo box
            loanBookCb.Items.Clear();
            // Bind the available books to the combo box
            loanBookCb.DataSource = db.GetAvailableBooks(); // Returns List<BookDisplay>
            loanBookCb.DisplayMember = "Title"; // What user sees (book title)
            loanBookCb.ValueMember = "BookID"; // What gets saved (BookID)
            loanBookCb.SelectedIndex = -1;     // Optionally set to no selection by default
        }


        //private void uc_AddLoan_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DatabaseHelper dbHelper = new DatabaseHelper();

        //        // Make sure these methods are returning valid data
        //        loanBookCb.DataSource = dbHelper.GetAvailableBookTitles();  // This should return a list of book titles
        //        loanBookCb.DisplayMember = "Title";
        //        loanBookCb.ValueMember = "CopyID";  // Assuming CopyID is available in your database

        //        loanMembercb.DataSource = dbHelper.GetActiveMemberNames();  // This should return a list of members
        //        loanMembercb.DisplayMember = "FullName";
        //        loanMembercb.ValueMember = "MemberID";  // Assuming MemberID is available in your database
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error initializing combo boxes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void saveLoanBtn_Click(object sender, EventArgs e)
        //{
        //    // 1. Validate that both combo boxes have valid selections
        //    if (loanBookCb.SelectedValue == null || loanMembercb.SelectedItem == null)
        //    {
        //        MessageBox.Show("Please select a member and a book before saving the loan.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    long selectedBookID = (long)loanBookCb.SelectedValue;

        //    // Get the first available copy for this book
        //    DatabaseHelper dbHelper = new DatabaseHelper(); // Create an instance of DatabaseHelper
        //    long selectedCopyID = dbHelper.GetFirstAvailableCopyID(selectedBookID);

        //    if (selectedCopyID == 0)
        //    {
        //        MessageBox.Show("No available copies left for this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Since loanMembercb is just storing strings (names), we’ll need to convert it back to ID
        //    string selectedMemberName = loanMembercb.SelectedItem.ToString();
        //    long selectedMemberID = dbHelper.GetMemberIdByName(selectedMemberName); // Use dbHelper to get member ID

        //    DateTime dueDate = dueDatePicker.Value;

        //    // 2. Validate that all required fields are selected
        //    if (selectedMemberID == 0 || dueDate == null)
        //    {
        //        MessageBox.Show("Please ensure all fields are selected and the due date is set.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // 3. Get the current user who is performing the action (assumed to be in session)
        //    long currentUserID = Session.LoggedInUserID; // Replace this with actual logged-in user ID

        //    try
        //    {
        //        // 4. Insert the loan into the database and update the book availability
        //        long loanID = dbHelper.InsertLoan(selectedMemberID, selectedCopyID, currentUserID, DateTime.Now, dueDate);

        //        // 5. Show a success message
        //        MessageBox.Show("Loan has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // 6. Redirect to the uc_Loans user control
        //        uc_Loans loansControl = new uc_Loans(mainform);
        //        mainform.SwitchUserControl(loansControl);
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any errors that occur during the loan insertion
        //        MessageBox.Show("An error occurred while saving the loan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private void saveLoanBtn_Click(object sender, EventArgs e)
        {
            // 1. Validate that both combo boxes have valid selections
            if (loanBookCb.SelectedValue == null || loanMembercb.SelectedItem == null)
            {
                MessageBox.Show("Please select a member and a book before saving the loan.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long selectedBookID = (long)loanBookCb.SelectedValue;

            // Get the first available copy for this book
            DatabaseHelper dbHelper = new DatabaseHelper();
            long selectedCopyID = dbHelper.GetFirstAvailableCopyID(selectedBookID);  // Use CopyID, not BookID

            if (selectedCopyID == 0)
            {
                MessageBox.Show("No available copies left for this book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Since loanMembercb is just storing strings (names), we’ll need to convert it back to ID
            string selectedMemberName = loanMembercb.SelectedItem.ToString();
            DatabaseHelper db = new DatabaseHelper(); // Add this here if not already declared
            long selectedMemberID = db.GetMemberIdByName(selectedMemberName); // Make sure you have this method

            DateTime dueDate = dueDatePicker.Value;

            // 2. Validate that all required fields are selected
            if (selectedCopyID == 0 || selectedMemberID == 0 || dueDate == null)
            {
                MessageBox.Show("Please ensure all fields are selected and the due date is set.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Get the current user who is performing the action (assumed to be in session)
            long currentUserID = Session.LoggedInUserID; // Replace this with actual logged-in user ID

            try
            {


                // Call method to save the loan and pass required parameters
                long loanID = dbHelper.InsertLoan(selectedMemberID, selectedCopyID, currentUserID, DateTime.Now, dueDate);

                // Mark the copy as unavailable after saving the loan
                dbHelper.MarkCopyAsUnavailable(selectedCopyID);


                // 5. Show a success message
                MessageBox.Show("Loan has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 6. Redirect to the uc_Loans user control
                uc_Loans loansControl = new uc_Loans(mainform);
                mainform.SwitchUserControl(loansControl);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the loan insertion
                MessageBox.Show("An error occurred while saving the loan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void discardLoanBtn_Click(object sender, EventArgs e)
        {
            uc_Loans loansControl = new uc_Loans(mainform);
            mainform.SwitchUserControl(loansControl);
        }



        //private void saveLoanBtn_Click(object sender, EventArgs e)
        //{
        //    // 1. Validate that a book and member have been selected
        //    if (loanBookCb.SelectedValue == null || loanMembercb.SelectedValue == null)
        //    {
        //        MessageBox.Show("Please select both a book and a member.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // 2. Get the selected values from the combo boxes and date picker
        //    long selectedBookCopyID = (long)loanBookCb.SelectedValue;  // CopyID from loanBookcb
        //    long selectedMemberID = (long)loanMembercb.SelectedValue; // MemberID from loanMembercb
        //    DateTime dueDate = dueDatePicker.Value;  // Due date from dueDatePicker

        //    // 3. Validate the due date
        //    if (dueDate == null)
        //    {
        //        MessageBox.Show("Please set the due date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // 4. Get the current user who is performing the action (assumed to be in session)
        //    long currentUserID = Session.LoggedInUserID; // Replace this with actual logged-in user ID

        //    try
        //    {
        //        // 5. Insert the loan into the database and update the book availability
        //        DatabaseHelper dbHelper = new DatabaseHelper();

        //        // Call method to save the loan and pass required parameters
        //        long loanID = dbHelper.InsertLoan(selectedMemberID, selectedBookCopyID, currentUserID, DateTime.Now, dueDate);

        //        // 6. Show a success message
        //        MessageBox.Show("Loan has been saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        // 7. Redirect to the uc_Loans user control
        //        uc_Loans loansControl = new uc_Loans(mainform);
        //        mainform.SwitchUserControl(loansControl);  // Switch to uc_Loans user control
        //    }
        //    catch (Exception ex)
        //    {
        //        // Handle any errors that occur during the loan insertion
        //        MessageBox.Show("An error occurred while saving the loan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}







    }
}
