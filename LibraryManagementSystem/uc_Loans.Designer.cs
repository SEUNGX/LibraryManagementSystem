namespace LibraryManagementSystem
{
    partial class uc_Loans
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
            addLoanBtn = new Button();
            SuspendLayout();
            // 
            // addLoanBtn
            // 
            addLoanBtn.BackColor = SystemColors.ButtonHighlight;
            addLoanBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLoanBtn.Image = Properties.Resources.icons8_give_50;
            addLoanBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addLoanBtn.Location = new Point(822, 436);
            addLoanBtn.Name = "addLoanBtn";
            addLoanBtn.Size = new Size(141, 65);
            addLoanBtn.TabIndex = 3;
            addLoanBtn.Text = "             Add\r\n             Loan";
            addLoanBtn.TextAlign = ContentAlignment.MiddleLeft;
            addLoanBtn.UseVisualStyleBackColor = false;
            addLoanBtn.Click += addLoanBtn_Click;
            // 
            // uc_Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addLoanBtn);
            Name = "uc_Loans";
            Size = new Size(1013, 542);
            ResumeLayout(false);
        }

        #endregion

        private Button addLoanBtn;
    }
}
