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
    public partial class uc_Reservations : UserControl
    {
        private string currentStatusFilter = "All";
        FormMain formMain;
        public uc_Reservations(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }


        private void LoadReservationTable()
        {
            DatabaseHelper db = new DatabaseHelper();
            reservationsDgv.DataSource = db.GetReservationDisplayData();

            ResetFineNavButtonStyles(); // First, reset others
            allReservationsBtn.BackColor = Color.OliveDrab; // Customize color
            allReservationsBtn.ForeColor = Color.White;

            // Prevent multiple subscriptions to RowPostPaint
            reservationsDgv.RowPostPaint -= ReservationsDgv_RowPostPaint;
            reservationsDgv.RowPostPaint += ReservationsDgv_RowPostPaint;

            // Hide ReservationID column if present
            if (reservationsDgv.Columns.Contains("ReservationID"))
                reservationsDgv.Columns["ReservationID"].Visible = false;

            // Show Status column in case it was hidden before
            if (reservationsDgv.Columns.Contains("Status"))
                reservationsDgv.Columns["Status"].Visible = true;

            // Adjust headers if columns exist
            if (reservationsDgv.Columns.Contains("BookTitle"))
                reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";

            if (reservationsDgv.Columns.Contains("MemberName"))
                reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";

            if (reservationsDgv.Columns.Contains("ReservationDate"))
                reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";

            if (reservationsDgv.Columns.Contains("ExpiryDate"))
                reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";

            // Format date columns
            if (reservationsDgv.Columns.Contains("ReservationDate"))
                reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            if (reservationsDgv.Columns.Contains("ExpiryDate"))
                reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        private void ReservationsDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = (DataGridView)sender;
            string rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle headerBounds = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                grid.RowHeadersWidth,
                e.RowBounds.Height);

            e.Graphics.DrawString(rowIdx, reservationsDgv.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }




        private void addReservationBtn_Click(object sender, EventArgs e)
        {
            uc_CreateReservation createReservationControl = new uc_CreateReservation(formMain);
            formMain.SwitchUserControl(createReservationControl);

            DatabaseHelper db = new DatabaseHelper();

            // Load books
            var bookTitles = db.GetAvailableBookTitles();
            createReservationControl.reserveBookTitleCb.DataSource = bookTitles;

            // Load members
            //var members = db.GetActiveMemberNames();
            //createReservationControl.reserveBookMemberCb.DataSource = members;
            List<Member> members = db.GetActiveMembers();
            createReservationControl.reserveBookMemberCb.DataSource = members;
            createReservationControl.reserveBookMemberCb.DisplayMember = "FullName";
            createReservationControl.reserveBookMemberCb.ValueMember = "MemberID";

        }

        private void uc_Reservations_Load(object sender, EventArgs e)
        {
            LoadReservationTable();
        }

        private void allReservationsBtn_Click(object sender, EventArgs e)
        {
            LoadReservationTable();
        }
        // Helper function to reset all column visibility to default (show all columns)
        private void ResetColumnVisibility()
        {
            foreach (DataGridViewColumn column in reservationsDgv.Columns)
            {
                column.Visible = true;  // Show all columns by default
            }
        }

        // Function to adjust column headers and visibility for Pending status
        private void AdjustPendingColumns()
        {
            // Hide the 'ReservationID' and 'Status' columns
            reservationsDgv.Columns["ReservationID"].Visible = false;
            reservationsDgv.Columns["Status"].Visible = false;

            // Set appropriate headers for Pending
            reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";
            reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";
            reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
            reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Hide 'ActionDate' (if it's present)
            if (reservationsDgv.Columns.Contains("ActionDate"))
            {
                reservationsDgv.Columns["ActionDate"].Visible = false;
            }
        }

        // Function to adjust column headers and visibility for Cancelled status
        private void AdjustCancelledColumns()
        {
            // Hide 'ReservationID' and 'Status' columns
            reservationsDgv.Columns["ReservationID"].Visible = false;
            reservationsDgv.Columns["Status"].Visible = false;

            // Set appropriate headers for Cancelled
            reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";
            reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";
            reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
            reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Show ActionDate as "Cancelled Date"
            reservationsDgv.Columns["ActionDate"].HeaderText = "Cancelled Date";
            reservationsDgv.Columns["ActionDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        // Function to adjust column headers and visibility for Expired status
        private void AdjustExpiredColumns()
        {
            // Hide 'ReservationID' and 'Status' columns
            reservationsDgv.Columns["ReservationID"].Visible = false;
            reservationsDgv.Columns["Status"].Visible = false;

            // Set appropriate headers for Expired
            reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";
            reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";
            reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
            reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Hide ActionDate (if it's present)
            if (reservationsDgv.Columns.Contains("ActionDate"))
            {
                reservationsDgv.Columns["ActionDate"].Visible = false;
            }
        }

        // Function to adjust column headers and visibility for Claimed status
        private void AdjustClaimedColumns()
        {
            // Hide 'ReservationID' and 'Status' columns
            reservationsDgv.Columns["ReservationID"].Visible = false;
            reservationsDgv.Columns["Status"].Visible = false;

            // Set appropriate headers for Claimed
            reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";
            reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";
            reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
            reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";
            reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            // Show ActionDate as "Claimed Date"
            reservationsDgv.Columns["ActionDate"].HeaderText = "Claimed Date";
            reservationsDgv.Columns["ActionDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
        }

        // Button handler for Pending Reservations
        private void pendingReservationsBtn_Click(object sender, EventArgs e)
        {
            currentStatusFilter = "Pending";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetFilteredReservationsByStatus("Pending");
            reservationsDgv.DataSource = dt;

            ResetFineNavButtonStyles(); // First, reset others
            pendingReservationsBtn.BackColor = Color.OliveDrab; // Customize color
            pendingReservationsBtn.ForeColor = Color.White;

            ResetColumnVisibility();  // Reset column visibility
            AdjustPendingColumns();    // Adjust columns for Pending status

            // Row number setup
            reservationsDgv.RowPostPaint -= ReservationsDgv_RowPostPaint;
            reservationsDgv.RowPostPaint += ReservationsDgv_RowPostPaint;
        }

        // Button handler for Cancelled Reservations
        private void cancelledReservationsBtn_Click(object sender, EventArgs e)
        {
            currentStatusFilter = "Cancelled";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetFilteredReservationsByStatus("Cancelled");
            reservationsDgv.DataSource = dt;

            ResetFineNavButtonStyles(); // First, reset others
            cancelledReservationsBtn.BackColor = Color.OliveDrab; // Customize color
            cancelledReservationsBtn.ForeColor = Color.White;

            ResetColumnVisibility();  // Reset column visibility
            AdjustCancelledColumns();  // Adjust columns for Cancelled status

            // Row number setup
            reservationsDgv.RowPostPaint -= ReservationsDgv_RowPostPaint;
            reservationsDgv.RowPostPaint += ReservationsDgv_RowPostPaint;
        }

        // Button handler for Expired Reservations
        private void expiredReservationsBtn_Click(object sender, EventArgs e)
        {   currentStatusFilter = "Expired";

            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetFilteredReservationsByStatus("Expired");
            reservationsDgv.DataSource = dt;

            ResetFineNavButtonStyles(); // First, reset others
            expiredReservationsBtn.BackColor = Color.OliveDrab; // Customize color
            expiredReservationsBtn.ForeColor = Color.White;

            ResetColumnVisibility();  // Reset column visibility
            AdjustExpiredColumns();    // Adjust columns for Expired status

            // Row number setup
            reservationsDgv.RowPostPaint -= ReservationsDgv_RowPostPaint;
            reservationsDgv.RowPostPaint += ReservationsDgv_RowPostPaint;
        }

        // Button handler for Claimed Reservations
        private void claimedReservationsBtn_Click(object sender, EventArgs e)
        {
            currentStatusFilter = "Claimed";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.GetFilteredReservationsByStatus("Claimed");
            reservationsDgv.DataSource = dt;

            ResetFineNavButtonStyles(); // First, reset others
            claimedReservationsBtn.BackColor = Color.OliveDrab; // Customize color
            claimedReservationsBtn.ForeColor = Color.White;

            ResetColumnVisibility();  // Reset column visibility
            AdjustClaimedColumns();    // Adjust columns for Claimed status

            // Row number setup
            reservationsDgv.RowPostPaint -= ReservationsDgv_RowPostPaint;
            reservationsDgv.RowPostPaint += ReservationsDgv_RowPostPaint;
        }



        private void claimBtn_Click(object sender, EventArgs e)
        {
            List<int> selectedReservationIds = new List<int>();

            foreach (DataGridViewRow row in reservationsDgv.SelectedRows)
            {
                if (row.Cells["ReservationID"].Value != null &&
                    row.Cells["Status"].Value.ToString() == "Pending")
                {
                    selectedReservationIds.Add(Convert.ToInt32(row.Cells["ReservationID"].Value));
                }
            }

            if (selectedReservationIds.Count == 0)
            {
                MessageBox.Show("Please select at least one reservation with status 'Pending' to mark as Claimed.");
                return;
            }

            // 🔮 Show popup to pick due date
            DueDatePickerForm dueDateForm = new DueDatePickerForm();
            if (dueDateForm.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Operation cancelled. No due date was selected.");
                return;
            }

            DateTime selectedDueDate = dueDateForm.SelectedDueDate;

            DatabaseHelper db = new DatabaseHelper();
            foreach (int reservationId in selectedReservationIds)
            {
                db.MarkReservationsAsClaimed(new List<int> { reservationId }, Session.LoggedInUserID);
                db.CreateLoanFromReservation(reservationId, Session.LoggedInUserID, selectedDueDate); // pass due date!
            }

            MessageBox.Show("Selected reservations have been claimed and converted to loans.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadReservationTable();
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            List<int> validReservationIds = new List<int>();

            foreach (DataGridViewRow row in reservationsDgv.SelectedRows)
            {
                if (row.Cells["ReservationID"].Value != null &&
                    row.Cells["Status"].Value.ToString() == "Pending")
                {
                    validReservationIds.Add(Convert.ToInt32(row.Cells["ReservationID"].Value));
                }
            }

            if (validReservationIds.Count == 0)
            {
                MessageBox.Show("Please select at least one reservation with status 'Pending' to cancel.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to cancel the selected reservation(s)?",
                                                  "Confirm Cancellation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DatabaseHelper db = new DatabaseHelper();
                foreach (int reservationID in validReservationIds)
                {
                    db.CancelReservation(reservationID, Session.LoggedInUserID);
                }

                MessageBox.Show("Selected reservation(s) cancelled successfully.");
                LoadReservationTable(); // Refresh the table after update
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.Trim();
            

            DatabaseHelper db = new DatabaseHelper();
            reservationsDgv.DataSource = db.GetFilteredReservationsByStatus(currentStatusFilter, keyword);

            SetupReservationGridColumns(currentStatusFilter); // optional helper to reapply column formatting
        }



        private void SetupReservationGridColumns(string status)
        {
            // Hide ReservationID
            if (reservationsDgv.Columns.Contains("ReservationID"))
                reservationsDgv.Columns["ReservationID"].Visible = false;

            // Hide Status column
            if (reservationsDgv.Columns.Contains("Status"))
                reservationsDgv.Columns["Status"].Visible = false;

            // Adjust headers
            if (reservationsDgv.Columns.Contains("BookTitle"))
                reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";

            if (reservationsDgv.Columns.Contains("MemberName"))
                reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";

            if (reservationsDgv.Columns.Contains("ReservationDate"))
            {
                reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
                reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            if (reservationsDgv.Columns.Contains("ExpiryDate"))
            {
                reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";
                reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            }

            if (reservationsDgv.Columns.Contains("ActionDate"))
            {
                if (status == "Cancelled")
                {
                    reservationsDgv.Columns["ActionDate"].HeaderText = "Cancelled Date";
                    reservationsDgv.Columns["ActionDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                }
                else if (status == "Claimed")
                {
                    reservationsDgv.Columns["ActionDate"].HeaderText = "Claimed Date";
                    reservationsDgv.Columns["ActionDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                }
                else
                {
                    reservationsDgv.Columns["ActionDate"].Visible = false;
                }
            }
        }


        private void ResetFineNavButtonStyles()
        {
            allReservationsBtn.BackColor = Color.White;
            cancelledReservationsBtn.BackColor = Color.White;
            claimedReservationsBtn.BackColor = Color.White;
            expiredReservationsBtn.BackColor = Color.White;
            pendingReservationsBtn.BackColor = Color.White;

            allReservationsBtn.ForeColor = Color.OliveDrab;
            cancelledReservationsBtn.ForeColor = Color.OliveDrab;
            claimedReservationsBtn.ForeColor = Color.OliveDrab;
            expiredReservationsBtn.ForeColor = Color.OliveDrab;
            pendingReservationsBtn.ForeColor = Color.OliveDrab;
        }
    }
}
