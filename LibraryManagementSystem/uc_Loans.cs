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
            LoadLoanTable();
        }

        private void allLoansBtn_Click(object sender, EventArgs e)
        {
            LoadLoanTable();
        }
    }
}
