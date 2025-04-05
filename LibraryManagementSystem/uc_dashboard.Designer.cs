namespace LibraryManagementSystem
{
    partial class uc_dashboard
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
            totalBooksPanel = new Panel();
            totalBooksLabel = new Label();
            currentLoansPanel = new Panel();
            totalMembersPanel = new Panel();
            totalBooksNumLabel = new Label();
            totalBooksPanel.SuspendLayout();
            SuspendLayout();
            // 
            // totalBooksPanel
            // 
            totalBooksPanel.BackColor = Color.NavajoWhite;
            totalBooksPanel.Controls.Add(totalBooksNumLabel);
            totalBooksPanel.Controls.Add(totalBooksLabel);
            totalBooksPanel.Location = new Point(40, 48);
            totalBooksPanel.Name = "totalBooksPanel";
            totalBooksPanel.Size = new Size(213, 191);
            totalBooksPanel.TabIndex = 11;
            // 
            // totalBooksLabel
            // 
            totalBooksLabel.AutoSize = true;
            totalBooksLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBooksLabel.Location = new Point(21, 15);
            totalBooksLabel.Name = "totalBooksLabel";
            totalBooksLabel.Size = new Size(176, 32);
            totalBooksLabel.TabIndex = 0;
            totalBooksLabel.Text = "Total Books";
            // 
            // currentLoansPanel
            // 
            currentLoansPanel.BackColor = Color.DarkSeaGreen;
            currentLoansPanel.Location = new Point(552, 48);
            currentLoansPanel.Name = "currentLoansPanel";
            currentLoansPanel.Size = new Size(213, 191);
            currentLoansPanel.TabIndex = 12;
            // 
            // totalMembersPanel
            // 
            totalMembersPanel.BackColor = Color.PaleGoldenrod;
            totalMembersPanel.Location = new Point(299, 48);
            totalMembersPanel.Name = "totalMembersPanel";
            totalMembersPanel.Size = new Size(213, 191);
            totalMembersPanel.TabIndex = 13;
            // 
            // totalBooksNumLabel
            // 
            totalBooksNumLabel.AutoSize = true;
            totalBooksNumLabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalBooksNumLabel.Location = new Point(88, 60);
            totalBooksNumLabel.Name = "totalBooksNumLabel";
            totalBooksNumLabel.Size = new Size(26, 27);
            totalBooksNumLabel.TabIndex = 1;
            totalBooksNumLabel.Text = "0";
            // 
            // uc_dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalBooksPanel);
            Controls.Add(currentLoansPanel);
            Controls.Add(totalMembersPanel);
            Name = "uc_dashboard";
            Size = new Size(1013, 542);
            totalBooksPanel.ResumeLayout(false);
            totalBooksPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel totalBooksPanel;
        private Label totalBooksLabel;
        private Panel currentLoansPanel;
        private Panel totalMembersPanel;
        private Label totalBooksNumLabel;
    }
}
