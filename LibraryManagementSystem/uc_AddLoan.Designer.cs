namespace LibraryManagementSystem
{
    partial class uc_AddLoan
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
            discardLoanBtn = new Button();
            saveLoanBtn = new Button();
            label4 = new Label();
            label3 = new Label();
            dueDatePicker = new DateTimePicker();
            label2 = new Label();
            loanMembercb = new ComboBox();
            label1 = new Label();
            loanBookCb = new ComboBox();
            SuspendLayout();
            // 
            // discardLoanBtn
            // 
            discardLoanBtn.BackColor = SystemColors.ButtonHighlight;
            discardLoanBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardLoanBtn.BackgroundImageLayout = ImageLayout.Center;
            discardLoanBtn.Location = new Point(848, 429);
            discardLoanBtn.Name = "discardLoanBtn";
            discardLoanBtn.Size = new Size(98, 64);
            discardLoanBtn.TabIndex = 24;
            discardLoanBtn.UseVisualStyleBackColor = false;
            discardLoanBtn.Click += discardLoanBtn_Click;
            // 
            // saveLoanBtn
            // 
            saveLoanBtn.BackColor = SystemColors.ButtonHighlight;
            saveLoanBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveLoanBtn.BackgroundImageLayout = ImageLayout.Center;
            saveLoanBtn.Location = new Point(744, 429);
            saveLoanBtn.Name = "saveLoanBtn";
            saveLoanBtn.Size = new Size(98, 64);
            saveLoanBtn.TabIndex = 23;
            saveLoanBtn.UseVisualStyleBackColor = false;
            saveLoanBtn.Click += saveLoanBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 50);
            label4.Name = "label4";
            label4.Size = new Size(196, 34);
            label4.TabIndex = 22;
            label4.Text = "Loan a Book";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 370);
            label3.Name = "label3";
            label3.Size = new Size(116, 27);
            label3.TabIndex = 21;
            label3.Text = "Due Date";
            // 
            // dueDatePicker
            // 
            dueDatePicker.CalendarFont = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDatePicker.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDatePicker.Format = DateTimePickerFormat.Short;
            dueDatePicker.Location = new Point(85, 413);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(256, 31);
            dueDatePicker.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 241);
            label2.Name = "label2";
            label2.Size = new Size(103, 27);
            label2.TabIndex = 19;
            label2.Text = "Member";
            // 
            // loanMembercb
            // 
            loanMembercb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanMembercb.FormattingEnabled = true;
            loanMembercb.Location = new Point(85, 284);
            loanMembercb.Name = "loanMembercb";
            loanMembercb.Size = new Size(455, 31);
            loanMembercb.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 113);
            label1.Name = "label1";
            label1.Size = new Size(70, 27);
            label1.TabIndex = 17;
            label1.Text = "Book";
            // 
            // loanBookCb
            // 
            loanBookCb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loanBookCb.FormattingEnabled = true;
            loanBookCb.Location = new Point(85, 159);
            loanBookCb.Name = "loanBookCb";
            loanBookCb.Size = new Size(643, 31);
            loanBookCb.TabIndex = 16;
            // 
            // uc_AddLoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardLoanBtn);
            Controls.Add(saveLoanBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dueDatePicker);
            Controls.Add(label2);
            Controls.Add(loanMembercb);
            Controls.Add(label1);
            Controls.Add(loanBookCb);
            Name = "uc_AddLoan";
            Size = new Size(1013, 542);
            Load += uc_AddLoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button discardLoanBtn;
        private Button saveLoanBtn;
        private Label label4;
        private Label label3;
        private DateTimePicker dueDatePicker;
        private Label label2;
        private ComboBox loanMembercb;
        private Label label1;
        private ComboBox loanBookCb;
    }
}
