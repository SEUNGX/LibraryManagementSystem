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
    public partial class uc_CreateReservation : UserControl
    {
        private long selectedCopyId;


        FormMain formMain;
        public uc_CreateReservation(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void uc_CreateReservation_Load(object sender, EventArgs e)
        {

        }

        private void saveReservationBtn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();

                // Get values from the combo boxes
                // Ensure the correct cast by checking the value type
                long selectedCopyId = this.selectedCopyId;  // This should be a long value based on your logic
                long selectedMemberId = (long)reserveBookMemberCb.SelectedValue;

                if (reserveBookMemberCb.SelectedValue != null && long.TryParse(reserveBookMemberCb.SelectedValue.ToString(), out selectedMemberId))
                {
                    // Successfully parsed selectedMemberId
                }
                else
                {
                    MessageBox.Show("Please select a valid member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                long createdByUserId = Session.LoggedInUserID;
                DateTime expiryDate = expiryDatePicker.Value;

                // Save the reservation
                dbHelper.CreateReservation(selectedCopyId, selectedMemberId, createdByUserId, expiryDate);

                // Update BookCopies table: set Status = 'Reserved', IsAvailable = 0
                dbHelper.UpdateBookCopyStatusToReserved(selectedCopyId);

                // Show success message
                MessageBox.Show("Reservation saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Switch to uc_Reservations
                uc_Reservations reservationsControl = new uc_Reservations(formMain);
                formMain.SwitchUserControl(reservationsControl);

                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void reserveBookTitleCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reserveBookTitleCb.SelectedItem == null)
                return;

            string selectedBookTitle = reserveBookTitleCb.SelectedItem.ToString();
            DatabaseHelper db = new DatabaseHelper();

            // Get the best available copy ID for the selected book title
            selectedCopyId = db.GetBestCopyIdByBookTitle(selectedBookTitle);

            if (selectedCopyId > 0)
            {
                var (isAvailable, dueDate) = db.GetCopyStatus(selectedCopyId);

                if (isAvailable)
                {
                    currentStatusLabel.Text = "Available";
                    dueDateLbl.Text = "N/A";  // Since it's available, no due date
                }
                else
                {
                    currentStatusLabel.Text = "Currently Loaned";
                    dueDateLbl.Text = dueDate.HasValue ? dueDate.Value.ToString("yyyy-MM-dd") : "N/A";
                }
            }
            else
            {
                currentStatusLabel.Text = "No available copies found.";
                dueDateLbl.Text = "N/A";
            }
        }

        private void discardReservationBtn_Click(object sender, EventArgs e)
        {
            uc_Reservations reservationsControl = new uc_Reservations(formMain);
            formMain.SwitchUserControl(reservationsControl);
    }
}
}
