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
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            addReservationBtn = new Button();
            panel1 = new Panel();
            reservationsDgv = new DataGridView();
            panel2 = new Panel();
            claimedReservationsBtn = new Button();
            cancelledReservationsBtn = new Button();
            expiredReservationsBtn = new Button();
            pendingReservationsBtn = new Button();
            allReservationsBtn = new Button();
            claimBtn = new Button();
            cancelBtn = new Button();
            label1 = new Label();
            searchBtn = new Button();
            searchBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsDgv).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // addReservationBtn
            // 
            addReservationBtn.BackColor = Color.LightGoldenrodYellow;
            addReservationBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addReservationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addReservationBtn.Location = new Point(891, 35);
            addReservationBtn.Name = "addReservationBtn";
            addReservationBtn.Size = new Size(71, 35);
            addReservationBtn.TabIndex = 3;
            addReservationBtn.Text = "Create \r\n\r\nReservation";
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
            reservationsDgv.AllowUserToAddRows = false;
            reservationsDgv.AllowUserToDeleteRows = false;
            reservationsDgv.AllowUserToResizeColumns = false;
            dataGridViewCellStyle17.BackColor = Color.Honeydew;
            dataGridViewCellStyle17.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle17.SelectionForeColor = Color.Green;
            reservationsDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            reservationsDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reservationsDgv.BackgroundColor = Color.Ivory;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.LightGreen;
            dataGridViewCellStyle18.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle18.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = Color.Honeydew;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.True;
            reservationsDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            reservationsDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.White;
            dataGridViewCellStyle19.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle19.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.False;
            reservationsDgv.DefaultCellStyle = dataGridViewCellStyle19;
            reservationsDgv.Dock = DockStyle.Fill;
            reservationsDgv.Location = new Point(0, 0);
            reservationsDgv.Name = "reservationsDgv";
            reservationsDgv.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.LightGreen;
            dataGridViewCellStyle20.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle20.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = Color.Honeydew;
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.True;
            reservationsDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            reservationsDgv.RowHeadersWidth = 51;
            reservationsDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            reservationsDgv.Size = new Size(899, 438);
            reservationsDgv.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(claimedReservationsBtn);
            panel2.Controls.Add(cancelledReservationsBtn);
            panel2.Controls.Add(expiredReservationsBtn);
            panel2.Controls.Add(pendingReservationsBtn);
            panel2.Controls.Add(allReservationsBtn);
            panel2.Location = new Point(63, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(425, 44);
            panel2.TabIndex = 5;
            // 
            // claimedReservationsBtn
            // 
            claimedReservationsBtn.BackColor = Color.White;
            claimedReservationsBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            claimedReservationsBtn.ForeColor = Color.OliveDrab;
            claimedReservationsBtn.Location = new Point(336, 11);
            claimedReservationsBtn.Name = "claimedReservationsBtn";
            claimedReservationsBtn.Size = new Size(87, 30);
            claimedReservationsBtn.TabIndex = 6;
            claimedReservationsBtn.Text = "Claimed";
            claimedReservationsBtn.UseVisualStyleBackColor = false;
            claimedReservationsBtn.Click += claimedReservationsBtn_Click;
            // 
            // cancelledReservationsBtn
            // 
            cancelledReservationsBtn.BackColor = Color.White;
            cancelledReservationsBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelledReservationsBtn.ForeColor = Color.OliveDrab;
            cancelledReservationsBtn.Location = new Point(150, 11);
            cancelledReservationsBtn.Name = "cancelledReservationsBtn";
            cancelledReservationsBtn.Size = new Size(92, 30);
            cancelledReservationsBtn.TabIndex = 3;
            cancelledReservationsBtn.Text = "Cancelled";
            cancelledReservationsBtn.UseVisualStyleBackColor = false;
            cancelledReservationsBtn.Click += cancelledReservationsBtn_Click;
            // 
            // expiredReservationsBtn
            // 
            expiredReservationsBtn.BackColor = Color.White;
            expiredReservationsBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiredReservationsBtn.ForeColor = Color.OliveDrab;
            expiredReservationsBtn.Location = new Point(248, 11);
            expiredReservationsBtn.Name = "expiredReservationsBtn";
            expiredReservationsBtn.Size = new Size(82, 29);
            expiredReservationsBtn.TabIndex = 4;
            expiredReservationsBtn.Text = "Expired";
            expiredReservationsBtn.UseVisualStyleBackColor = false;
            expiredReservationsBtn.Click += expiredReservationsBtn_Click;
            // 
            // pendingReservationsBtn
            // 
            pendingReservationsBtn.BackColor = Color.White;
            pendingReservationsBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pendingReservationsBtn.ForeColor = Color.OliveDrab;
            pendingReservationsBtn.Location = new Point(60, 11);
            pendingReservationsBtn.Name = "pendingReservationsBtn";
            pendingReservationsBtn.Size = new Size(84, 30);
            pendingReservationsBtn.TabIndex = 2;
            pendingReservationsBtn.Text = "Pending";
            pendingReservationsBtn.UseVisualStyleBackColor = false;
            pendingReservationsBtn.Click += pendingReservationsBtn_Click;
            // 
            // allReservationsBtn
            // 
            allReservationsBtn.BackColor = Color.White;
            allReservationsBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allReservationsBtn.ForeColor = Color.OliveDrab;
            allReservationsBtn.Location = new Point(0, 11);
            allReservationsBtn.Name = "allReservationsBtn";
            allReservationsBtn.Size = new Size(54, 30);
            allReservationsBtn.TabIndex = 1;
            allReservationsBtn.Text = "All";
            allReservationsBtn.UseVisualStyleBackColor = false;
            allReservationsBtn.Click += allReservationsBtn_Click;
            // 
            // claimBtn
            // 
            claimBtn.BackColor = Color.OliveDrab;
            claimBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            claimBtn.ForeColor = Color.Cornsilk;
            claimBtn.Location = new Point(721, 33);
            claimBtn.Name = "claimBtn";
            claimBtn.Size = new Size(79, 38);
            claimBtn.TabIndex = 7;
            claimBtn.Text = "Claim";
            claimBtn.UseVisualStyleBackColor = false;
            claimBtn.Click += claimBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.OliveDrab;
            cancelBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.Cornsilk;
            cancelBtn.Location = new Point(806, 33);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(79, 38);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.OliveDrab;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 27);
            label1.TabIndex = 9;
            label1.Text = "Reservations";
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.White;
            searchBtn.BackgroundImage = Properties.Resources.icons8_search_30;
            searchBtn.BackgroundImageLayout = ImageLayout.Center;
            searchBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(680, 35);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(35, 38);
            searchBtn.TabIndex = 11;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(492, 41);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(189, 27);
            searchBox.TabIndex = 10;
            // 
            // uc_Reservations
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(searchBtn);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(claimBtn);
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
            PerformLayout();
        }

        #endregion

        private Button addReservationBtn;
        private Panel panel1;
        private DataGridView reservationsDgv;
        private Panel panel2;
        private Button allReservationsBtn;
        private Button pendingReservationsBtn;
        private Button cancelledReservationsBtn;
        private Button claimedReservationsBtn;
        private Button expiredReservationsBtn;
        private Button claimBtn;
        private Button cancelBtn;
        private Label label1;
        private Button searchBtn;
        private TextBox searchBox;
    }
}
