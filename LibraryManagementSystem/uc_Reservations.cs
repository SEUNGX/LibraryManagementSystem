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

            reservationsDgv.RowPostPaint += (s, eArgs) =>
            {
                var grid = (DataGridView)s;
                var rowIdx = (eArgs.RowIndex + 1).ToString();

                var centerFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };

                Rectangle headerBounds = new Rectangle(
                    eArgs.RowBounds.Left,
                    eArgs.RowBounds.Top,
                    grid.RowHeadersWidth,
                    eArgs.RowBounds.Height);

                eArgs.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
            };



            // Hide ReservationID column
            if (reservationsDgv.Columns.Contains("ReservationID"))
            {
                reservationsDgv.Columns["ReservationID"].Visible = false;
            }

            // Set column headers
            reservationsDgv.Columns["BookTitle"].HeaderText = "Book Title";
            reservationsDgv.Columns["MemberName"].HeaderText = "Member Name";
            reservationsDgv.Columns["ReservationDate"].HeaderText = "Reservation Date";
            reservationsDgv.Columns["ExpiryDate"].HeaderText = "Expiry Date";

            reservationsDgv.Columns["ReservationDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
            reservationsDgv.Columns["ExpiryDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

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
    }
}
