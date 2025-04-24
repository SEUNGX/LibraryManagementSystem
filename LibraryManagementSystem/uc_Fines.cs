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

            finesDgv.RowPostPaint += new DataGridViewRowPostPaintEventHandler(finesDgv_RowPostPaint);


            finesDgv.Columns["FineID"].Visible = false;

            finesDgv.Columns["BookTitle"].HeaderText = "Book Name";
            finesDgv.Columns["MemberName"].HeaderText = "Member Name";
            finesDgv.Columns["DueDate"].HeaderText = "Due Date";
            finesDgv.Columns["ReturnDate"].HeaderText = "Return Date";
            finesDgv.Columns["Status"].HeaderText = "Loan Status";
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

        
    }
}
