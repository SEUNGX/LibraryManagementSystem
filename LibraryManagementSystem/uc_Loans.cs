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
    public partial class uc_Loans : UserControl
    {
        private string currentLoanStatusFilter = "All";


        FormMain mainForm;

        public uc_Loans(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addLoanBtn_Click(object sender, EventArgs e)
        {
            uc_AddLoan addLoanControl = new uc_AddLoan(mainForm);
            mainForm.SwitchUserControl(addLoanControl);
        }

        private void LoadLoanTable()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable loanData = db.GetLoanDisplayData();

                if (loanData != null)
                {
                    loansDgv.DataSource = loanData;

                    // Configure DataGridView behavior
                    loansDgv.ReadOnly = true;
                    loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    loansDgv.MultiSelect = true;
                    loansDgv.AllowUserToAddRows = false;
                    loansDgv.RowHeadersVisible = true;

                    loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
                    loansDgv.RowPostPaint += loansDgv_RowPostPaint;


                    // Auto-size specific columns if they exist
                    if (loansDgv.Columns.Contains("Book Title"))
                        loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (loansDgv.Columns.Contains("Member Name"))
                        loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    // Add row numbers in row headers
                    for (int i = 0; i < loansDgv.Rows.Count; i++)
                    {
                        loansDgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No data returned.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loan table: " + ex.Message);
            }
        }

        private void loansDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString();

            using (SolidBrush brush = new SolidBrush(grid.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(rowNumber, grid.Font, brush,
                    e.RowBounds.Location.X + 10,
                    e.RowBounds.Location.Y + 4);
            }
        }



        private void uc_Loans_Load(object sender, EventArgs e)
        {
            currentLoanStatusFilter = "All";
            LoadLoanTable();
        }

        private void allLoansBtn_Click(object sender, EventArgs e)
        {
            currentLoanStatusFilter = "All";
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable loanData = db.GetLoanDisplayData();

                if (loanData != null)
                {
                    loansDgv.DataSource = loanData;

                    // Configure DataGridView behavior
                    loansDgv.ReadOnly = true;
                    loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    loansDgv.MultiSelect = true;
                    loansDgv.AllowUserToAddRows = false;
                    loansDgv.RowHeadersVisible = true;

                    loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
                    loansDgv.RowPostPaint += loansDgv_RowPostPaint;


                    // Auto-size specific columns if they exist
                    if (loansDgv.Columns.Contains("Book Title"))
                        loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (loansDgv.Columns.Contains("Member Name"))
                        loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



                }
                else
                {
                    MessageBox.Show("No data returned.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading loan table: " + ex.Message);
            }
        }

        private void onLoanBtn_Click(object sender, EventArgs e)
        {
            currentLoanStatusFilter = "On Loan";
            LoadLoanTableByStatus("On Loan");
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable activeLoans = db.GetActiveLoanDisplayData();

                if (activeLoans != null)
                {
                    loansDgv.DataSource = activeLoans;

                    loansDgv.ReadOnly = true;
                    loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    loansDgv.MultiSelect = true;
                    loansDgv.AllowUserToAddRows = false;
                    loansDgv.RowHeadersVisible = true;

                    if (loansDgv.Columns.Contains("LoanID"))
                        loansDgv.Columns["LoanID"].Visible = false;


                    loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
                    loansDgv.RowPostPaint += loansDgv_RowPostPaint;

                    if (loansDgv.Columns.Contains("Book Title"))
                        loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (loansDgv.Columns.Contains("Member Name"))
                        loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                }
                else
                {
                    MessageBox.Show("No active loans found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active loans: " + ex.Message);
            }
        }

        private void returnedLoansBtn_Click(object sender, EventArgs e)
        {
            currentLoanStatusFilter = "Returned";
            LoadLoanTableByStatus("Returned");
            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable returnedLoans = db.GetReturnedLoanDisplayData();

                if (returnedLoans != null)
                {
                    loansDgv.DataSource = returnedLoans;

                    loansDgv.ReadOnly = true;
                    loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    loansDgv.MultiSelect = true;
                    loansDgv.AllowUserToAddRows = false;
                    loansDgv.RowHeadersVisible = true;

                    if (loansDgv.Columns.Contains("LoanID"))
                        loansDgv.Columns["LoanID"].Visible = false;


                    loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
                    loansDgv.RowPostPaint += loansDgv_RowPostPaint;

                    if (loansDgv.Columns.Contains("Book Title"))
                        loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (loansDgv.Columns.Contains("Member Name"))
                        loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


                }
                else
                {
                    MessageBox.Show("No returned loans found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading returned loans: " + ex.Message);
            }
        }

        private void overdueLoansBtn_Click(object sender, EventArgs e)
        {
            currentLoanStatusFilter = "Overdue";
            LoadLoanTableByStatus("Overdue");

            try
            {
                DatabaseHelper db = new DatabaseHelper();
                DataTable overdueLoans = db.GetOverdueLoanDisplayData();

                if (overdueLoans != null)
                {
                    loansDgv.DataSource = overdueLoans;

                    loansDgv.ReadOnly = true;
                    loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    loansDgv.MultiSelect = true;
                    loansDgv.AllowUserToAddRows = false;
                    loansDgv.RowHeadersVisible = true;

                    if (loansDgv.Columns.Contains("LoanID"))
                        loansDgv.Columns["LoanID"].Visible = false;


                    loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
                    loansDgv.RowPostPaint += loansDgv_RowPostPaint;

                    if (loansDgv.Columns.Contains("Book Title"))
                        loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    if (loansDgv.Columns.Contains("Member Name"))
                        loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    for (int i = 0; i < loansDgv.Rows.Count; i++)
                    {
                        loansDgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No overdue loans found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading overdue loans: " + ex.Message);
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            if (loansDgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select at least one loan to mark as returned.");
                return;
            }

            // Confirm if the user wants to return the selected loans
            DialogResult confirm = MessageBox.Show("Mark selected loan(s) as returned?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            DatabaseHelper db = new DatabaseHelper();

            foreach (DataGridViewRow row in loansDgv.SelectedRows)
            {
                if (row.Cells["Loan Date"] != null)
                {
                    int loanId = Convert.ToInt32(row.Cells["LoanID"].Value);
                    string loanStatus = row.Cells["Status"].Value.ToString();  // Get the status of the loan

                    // Only allow return for loans that are On Loan or Overdue
                    if (loanStatus == "On Loan" || loanStatus == "Overdue")
                    {
                        db.ReturnLoan(loanId, Session.LoggedInUserID);  // Proceed to mark the loan as returned
                    }
                    else
                    {
                        MessageBox.Show("You can only return loans that are On Loan or Overdue.");
                        return;
                    }
                }
            }

            MessageBox.Show("Selected loan(s) marked as returned.");
            LoadLoanTable(); // Refresh the DataGridView
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string keyword = searchLoansTb.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Please enter a keyword to search.");
                return;
            }

            DatabaseHelper db = new DatabaseHelper();
            DataTable results = db.SearchLoans(keyword, currentLoanStatusFilter);
            loansDgv.DataSource = results;
            FormatLoansDgv();
        }
        private void LoadLoanTableByStatus(string status)
        {
            DatabaseHelper db = new DatabaseHelper();
            DataTable data = db.GetLoanDisplayDataByStatus(status);
            loansDgv.DataSource = data;
            FormatLoansDgv();
        }
        private void FormatLoansDgv()
        {
            if (loansDgv.Columns.Contains("Book Title"))
                loansDgv.Columns["Book Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            if (loansDgv.Columns.Contains("Member Name"))
                loansDgv.Columns["Member Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            loansDgv.ReadOnly = true;
            loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loansDgv.MultiSelect = true;
            loansDgv.AllowUserToAddRows = false;
            loansDgv.RowHeadersVisible = true;

            loansDgv.RowPostPaint -= loansDgv_RowPostPaint;
            loansDgv.RowPostPaint += loansDgv_RowPostPaint;

            for (int i = 0; i < loansDgv.Rows.Count; i++)
            {
                loansDgv.Rows[i].HeaderCell.Value = (i + 1).ToString();
            }
        }



    }
}
