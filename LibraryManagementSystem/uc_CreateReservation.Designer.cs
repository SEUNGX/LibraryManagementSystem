namespace LibraryManagementSystem
{
    partial class uc_CreateReservation
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
            label1 = new Label();
            reserveBookTitleCb = new ComboBox();
            label2 = new Label();
            reserveBookMemberCb = new ComboBox();
            label3 = new Label();
            expiryDatePicker = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            currentStatusLabel = new Label();
            panel1 = new Panel();
            label6 = new Label();
            dueDateLbl = new Label();
            discardReservationBtn = new Button();
            saveReservationBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 120);
            label1.Name = "label1";
            label1.Size = new Size(124, 27);
            label1.TabIndex = 0;
            label1.Text = "Book Title";
            // 
            // reserveBookTitleCb
            // 
            reserveBookTitleCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserveBookTitleCb.FormattingEnabled = true;
            reserveBookTitleCb.Location = new Point(72, 163);
            reserveBookTitleCb.Name = "reserveBookTitleCb";
            reserveBookTitleCb.Size = new Size(347, 31);
            reserveBookTitleCb.TabIndex = 1;
            reserveBookTitleCb.SelectedIndexChanged += reserveBookTitleCb_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 47);
            label2.Name = "label2";
            label2.Size = new Size(245, 34);
            label2.TabIndex = 2;
            label2.Text = "Reserve a Book";
            // 
            // reserveBookMemberCb
            // 
            reserveBookMemberCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reserveBookMemberCb.FormattingEnabled = true;
            reserveBookMemberCb.Location = new Point(72, 271);
            reserveBookMemberCb.Name = "reserveBookMemberCb";
            reserveBookMemberCb.Size = new Size(310, 31);
            reserveBookMemberCb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 227);
            label3.Name = "label3";
            label3.Size = new Size(174, 27);
            label3.TabIndex = 3;
            label3.Text = "Member Name";
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expiryDatePicker.Format = DateTimePickerFormat.Short;
            expiryDatePicker.Location = new Point(67, 395);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(250, 31);
            expiryDatePicker.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 353);
            label4.Name = "label4";
            label4.Size = new Size(140, 27);
            label4.TabIndex = 6;
            label4.Text = "Expiry Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 27);
            label5.Name = "label5";
            label5.Size = new Size(179, 32);
            label5.TabIndex = 7;
            label5.Text = "Book Status";
            // 
            // currentStatusLabel
            // 
            currentStatusLabel.AutoSize = true;
            currentStatusLabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            currentStatusLabel.Location = new Point(28, 74);
            currentStatusLabel.Name = "currentStatusLabel";
            currentStatusLabel.Size = new Size(19, 27);
            currentStatusLabel.TabIndex = 8;
            currentStatusLabel.Text = ".";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dueDateLbl);
            panel1.Controls.Add(currentStatusLabel);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(557, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 266);
            panel1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(28, 134);
            label6.Name = "label6";
            label6.Size = new Size(218, 32);
            label6.TabIndex = 10;
            label6.Text = "Book Due Date";
            // 
            // dueDateLbl
            // 
            dueDateLbl.AutoSize = true;
            dueDateLbl.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDateLbl.Location = new Point(28, 178);
            dueDateLbl.Name = "dueDateLbl";
            dueDateLbl.Size = new Size(19, 27);
            dueDateLbl.TabIndex = 9;
            dueDateLbl.Text = ".";
            // 
            // discardReservationBtn
            // 
            discardReservationBtn.BackColor = SystemColors.ButtonHighlight;
            discardReservationBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardReservationBtn.BackgroundImageLayout = ImageLayout.Center;
            discardReservationBtn.Location = new Point(867, 432);
            discardReservationBtn.Name = "discardReservationBtn";
            discardReservationBtn.Size = new Size(98, 64);
            discardReservationBtn.TabIndex = 15;
            discardReservationBtn.UseVisualStyleBackColor = false;
            discardReservationBtn.Click += discardReservationBtn_Click;
            // 
            // saveReservationBtn
            // 
            saveReservationBtn.BackColor = SystemColors.ButtonHighlight;
            saveReservationBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveReservationBtn.BackgroundImageLayout = ImageLayout.Center;
            saveReservationBtn.Location = new Point(763, 432);
            saveReservationBtn.Name = "saveReservationBtn";
            saveReservationBtn.Size = new Size(98, 64);
            saveReservationBtn.TabIndex = 14;
            saveReservationBtn.UseVisualStyleBackColor = false;
            saveReservationBtn.Click += saveReservationBtn_Click;
            // 
            // uc_CreateReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardReservationBtn);
            Controls.Add(saveReservationBtn);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(expiryDatePicker);
            Controls.Add(reserveBookMemberCb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(reserveBookTitleCb);
            Controls.Add(label1);
            Name = "uc_CreateReservation";
            Size = new Size(1013, 542);
            Load += uc_CreateReservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private DateTimePicker expiryDatePicker;
        private Label label4;
        private Label label5;
        private Label currentStatusLabel;
        private Panel panel1;
        private Button discardReservationBtn;
        private Button saveReservationBtn;
        private Label label6;
        private Label dueDateLbl;
        public ComboBox reserveBookTitleCb;
        public ComboBox reserveBookMemberCb;
    }
}
