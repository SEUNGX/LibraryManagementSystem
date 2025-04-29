namespace LibraryManagementSystem
{
    partial class uc_Reservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            addReservationBtn = new Button();
            panel1 = new Panel();
            reservationsDgv = new DataGridView();
            panel2 = new Panel();
            allReservationsBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsDgv).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // addReservationBtn
            // 
            addReservationBtn.BackColor = Color.LightGoldenrodYellow;
            addReservationBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addReservationBtn.Image = Properties.Resources.icons8_book_40;
            addReservationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addReservationBtn.Location = new Point(861, 22);
            addReservationBtn.Name = "addReservationBtn";
            addReservationBtn.Size = new Size(138, 49);
            addReservationBtn.TabIndex = 3;
            addReservationBtn.Text = "        Create \r\n        Reservation";
            addReservationBtn.TextAlign = ContentAlignment.MiddleLeft;
            addReservationBtn.UseVisualStyleBackColor = false;
            addReservationBtn.Click += addReservationBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(reservationsDgv);
            panel1.Location = new Point(63, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 438);
            panel1.TabIndex = 4;
            // 
            // reservationsDgv
            // 
            reservationsDgv.ReadOnly = true;

            reservationsDgv.AllowUserToAddRows = false;
            reservationsDgv.AllowUserToDeleteRows = false;
            reservationsDgv.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = Color.Honeydew;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Green;
            reservationsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            reservationsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationsDgv.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightGreen;
            dataGridViewCellStyle2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Honeydew;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            reservationsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            reservationsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            reservationsDgv.DefaultCellStyle = dataGridViewCellStyle3;
            reservationsDgv.Dock = DockStyle.Fill;
            reservationsDgv.Location = new Point(0, 0);
            reservationsDgv.Name = "reservationsDgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.LightGreen;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Honeydew;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            reservationsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            reservationsDgv.RowHeadersWidth = 51;
            reservationsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsDgv.Size = new Size(899, 438);
            reservationsDgv.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(allReservationsBtn);
            panel2.Location = new Point(63, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 41);
            panel2.TabIndex = 5;
            // 
            // allReservationsBtn
            // 
            allReservationsBtn.BackColor = Color.White;
            allReservationsBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allReservationsBtn.ForeColor = Color.OliveDrab;
            allReservationsBtn.Location = new Point(0, 0);
            allReservationsBtn.Name = "allReservationsBtn";
            allReservationsBtn.Size = new Size(70, 41);
            allReservationsBtn.TabIndex = 1;
            allReservationsBtn.Text = "All";
            allReservationsBtn.UseVisualStyleBackColor = false;
            allReservationsBtn.Click += allReservationsBtn_Click;
            // 
            // uc_Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(addReservationBtn);
            Name = "uc_Reservations";
            Size = new Size(1013, 542);
            Load += uc_Reservations_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationsDgv).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button addReservationBtn;
        private Panel panel1;
        private DataGridView reservationsDgv;
        private Panel panel2;
        private Button allReservationsBtn;
    }
}
