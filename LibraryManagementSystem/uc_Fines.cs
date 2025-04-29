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
    public partial class uc_Fines : UserControl
    {

        private string currentView = "All";

        FormMain formMain;
        public uc_Fines(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;




            LoadAllFines();

        }

        private void LoadAllFines()
        {

            DatabaseHelper db = new DatabaseHelper();
            finesDgv.DataSource = db.GetAllFines();

            ResetFineNavButtonStyles(); // First, reset others
            allFinesBtn.BackColor = Color.DarkGoldenrod; // Customize color
            allFinesBtn.ForeColor = Color.White;

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);


            finesDgv.Columns["FineID"].Visible = false;

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["ReturnDate"].HeaderText = "Return Date";
            finesDgv.Columns["Status"].HeaderText = "Loan Status";

            finesDgv.Columns["DueDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            if (finesDgv == null)
            {
                MessageBox.Show("DataGridView is not initialized.");
                return;
            }

        }

        private void finesDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();
            using (SolidBrush brush = new SolidBrush(grid.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(rowNumber, grid.DefaultCellStyle.Font,
                    brush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }

        private void allFinesBtn_Click(object sender, EventArgs e)
        {
            currentView = "All";

            DatabaseHelper db = new DatabaseHelper();
            finesDgv.DataSource = db.GetAllFines();

            ResetFineNavButtonStyles(); // First, reset others
            allFinesBtn.BackColor = Color.DarkGoldenrod; // Customize color
            allFinesBtn.ForeColor = Color.White;

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);


            finesDgv.Columns["FineID"].Visible = false;
            if (finesDgv.Columns.Contains("Status"))
            {
                finesDgv.Columns["Status"].Visible = true;
            }

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["ReturnDate"].HeaderText = "Return Date";
            finesDgv.Columns["Status"].HeaderText = "Loan Status";

            finesDgv.Columns["DueDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

            if (finesDgv == null)
            {
                MessageBox.Show("DataGridView is not initialized.");
                return;
            }


        }

        private void paidFinesBtn_Click(object sender, EventArgs e)
        {
            currentView = "Paid";

            DatabaseHelper db = new DatabaseHelper();
            finesDgv.DataSource = db.GetPaidFines();

            ResetFineNavButtonStyles(); // First, reset others
            paidFinesBtn.BackColor = Color.DarkGoldenrod; // Customize color
            paidFinesBtn.ForeColor = Color.White;

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);

            finesDgv.Columns["FineID"].Visible = false;
            finesDgv.Columns["Status"].Visible = false; // Hide the Status column

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["ReturnDate"].HeaderText = "Return Date";
        }

        private void unpaidFinesBtn_Click(object sender, EventArgs e)
        {
            currentView = "Unpaid";

            DatabaseHelper db = new DatabaseHelper();
            finesDgv.DataSource = db.GetUnpaidFines();

            ResetFineNavButtonStyles(); // First, reset others
            unpaidFinesBtn.BackColor = Color.DarkGoldenrod; // Customize color
            unpaidFinesBtn.ForeColor = Color.White;

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);

            finesDgv.Columns["FineID"].Visible = false;
            finesDgv.Columns["Status"].Visible = false; // Hide the Fine Status column

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["ReturnDate"].HeaderText = "Return Date";
            finesDgv.Columns["Amount"].HeaderText = "Fine Amount";
            finesDgv.Columns["Amount"].DefaultCellStyle.Format = "C2"; // Format as currency
        }




        private void setPaidBtn_Click(object sender, EventArgs e)
        {
            if (finesDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one fine to mark as paid.");
                return;
            }

            List<long> selectedFineIds = new List<long>();
            foreach (DataGridViewRow row in finesDgv.SelectedRows)
            {
                selectedFineIds.Add(Convert.ToInt64(row.Cells["FineID"].Value));
            }

            DatabaseHelper db = new DatabaseHelper();
            db.MarkFinesAsPaid(selectedFineIds);

            MessageBox.Show("Selected fine(s) marked as paid.");
            LoadAllFines(); // Or refresh unpaid if you're showing only unpaid
        }

        private void ResetFineNavButtonStyles()
        {
            allFinesBtn.BackColor = Color.White;
            paidFinesBtn.BackColor = Color.White;
            unpaidFinesBtn.BackColor = Color.White;
            waivedFinesBtn.BackColor = Color.White;

            allFinesBtn.ForeColor = Color.DarkGoldenrod;
            paidFinesBtn.ForeColor = Color.DarkGoldenrod;
            unpaidFinesBtn.ForeColor = Color.DarkGoldenrod;
            waivedFinesBtn.ForeColor = Color.DarkGoldenrod;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchBox.Text.Trim().ToLower();
            DatabaseHelper db = new DatabaseHelper();

            switch (currentView)
            {
                case "All":
                    finesDgv.DataSource = db.SearchAllFines(keyword);
                    break;
                case "Paid":
                    finesDgv.DataSource = db.SearchPaidFines(keyword);
                    break;
                case "Unpaid":
                    finesDgv.DataSource = db.SearchUnpaidFines(keyword);
                    break;
            }
        }



        private void waivedFinesBtn_Click(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            finesDgv.DataSource = db.GetWaivedFines();

            ResetFineNavButtonStyles(); // First, reset others
            waivedFinesBtn.BackColor = Color.DarkGoldenrod; // Customize color
            waivedFinesBtn.ForeColor = Color.White;

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);

            finesDgv.Columns["FineID"].Visible = false; // Hide FineID column
            finesDgv.Columns["Status"].Visible = false; // Hide Status column

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["PaidDate"].HeaderText = "Waived Date"; // Display PaidDate as the date the fine was waived
        }

        private void waiveBtn_Click(object sender, EventArgs e)
        {
            if (finesDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one fine to waive.");
                return;
            }

            List<long> selectedFineIds = new List<long>();
            foreach (DataGridViewRow row in finesDgv.SelectedRows)
            {
                string status = row.Cells["Status"].Value?.ToString().Trim().ToLower();
                if (status == "Paid")
                {
                    MessageBox.Show("One or more selected fines are already paid and cannot be waived.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (status == "Waived")
                {
                    MessageBox.Show("One or more selected fines have already been waived.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                selectedFineIds.Add(Convert.ToInt64(row.Cells["FineID"].Value));
            }

            DatabaseHelper db = new DatabaseHelper();
            db.WaiveFines(selectedFineIds, Session.LoggedInUserID);

            MessageBox.Show("Selected fine(s) have been waived.");
            LoadAllFines(); // Or LoadUnpaidFines if you're showing unpaid ones
        }






    }
}
