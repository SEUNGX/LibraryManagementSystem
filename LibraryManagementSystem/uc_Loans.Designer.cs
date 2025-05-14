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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            addLoanBtn = new Button();
            panel1 = new Panel();
            loansDgv = new DataGridView();
            allLoansBtn = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loansDgv).BeginInit();
            SuspendLayout();
            // 
            // addLoanBtn
            // 
            addLoanBtn.BackColor = SystemColors.ButtonHighlight;
            addLoanBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLoanBtn.Image = Properties.Resources.icons8_give_50;
            addLoanBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addLoanBtn.Location = new Point(852, 0);
            addLoanBtn.Name = "addLoanBtn";
            addLoanBtn.Size = new Size(141, 65);
            addLoanBtn.TabIndex = 3;
            addLoanBtn.Text = "             Add\r\n             Loan";
            addLoanBtn.TextAlign = ContentAlignment.MiddleLeft;
            addLoanBtn.UseVisualStyleBackColor = false;
            addLoanBtn.Click += addLoanBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(loansDgv);
            panel1.Location = new Point(56, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 438);
            panel1.TabIndex = 4;
            // 
            // loansDgv
            // 
            loansDgv.AllowUserToAddRows = false;
            dataGridViewCellStyle5.BackColor = Color.Ivory;
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.SkyBlue;
            dataGridViewCellStyle5.SelectionForeColor = Color.DarkSlateGray;
            loansDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.PowderBlue;
            dataGridViewCellStyle6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            loansDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            loansDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.AliceBlue;
            dataGridViewCellStyle7.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle7.SelectionForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            loansDgv.DefaultCellStyle = dataGridViewCellStyle7;
            loansDgv.Dock = DockStyle.Fill;
            loansDgv.Location = new Point(0, 0);
            loansDgv.Name = "loansDgv";
            loansDgv.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.LightSteelBlue;
            dataGridViewCellStyle8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            loansDgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            loansDgv.RowHeadersWidth = 51;
            loansDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loansDgv.Size = new Size(899, 438);
            loansDgv.TabIndex = 0;
            // 
            // allLoansBtn
            // 
            allLoansBtn.BackColor = Color.White;
            allLoansBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allLoansBtn.ForeColor = Color.SteelBlue;
            allLoansBtn.Location = new Point(56, 35);
            allLoansBtn.Name = "allLoansBtn";
            allLoansBtn.Size = new Size(54, 30);
            allLoansBtn.TabIndex = 5;
            allLoansBtn.Text = "All";
            allLoansBtn.UseVisualStyleBackColor = false;
            allLoansBtn.Click += allLoansBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.SteelBlue;
            button1.Location = new Point(116, 35);
            button1.Name = "button1";
            button1.Size = new Size(54, 30);
            button1.TabIndex = 6;
            button1.Text = "All";
            button1.UseVisualStyleBackColor = false;
            // 
            // uc_Loans
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(allLoansBtn);
            Controls.Add(panel1);
            Controls.Add(addLoanBtn);
            Name = "uc_Loans";
            Size = new Size(1013, 542);
            Load += uc_Loans_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loansDgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button addLoanBtn;
        private Panel panel1;
        private DataGridView loansDgv;
        private Button allLoansBtn;
        private Button button1;
    }
}
