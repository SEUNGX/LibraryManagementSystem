namespace LibraryManagementSystem
{
    partial class uc_Members
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
            addMemberBtn = new Button();
            SuspendLayout();
            // 
            // addMemberBtn
            // 
            addMemberBtn.BackColor = SystemColors.ButtonHighlight;
            addMemberBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addMemberBtn.Image = Properties.Resources.icons8_customer_64;
            addMemberBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addMemberBtn.Location = new Point(799, 439);
            addMemberBtn.Name = "addMemberBtn";
            addMemberBtn.Size = new Size(175, 65);
            addMemberBtn.TabIndex = 2;
            addMemberBtn.Text = "             Add\r\n             Member";
            addMemberBtn.TextAlign = ContentAlignment.MiddleLeft;
            addMemberBtn.UseVisualStyleBackColor = false;
            addMemberBtn.Click += addMemberBtn_Click;
            // 
            // uc_Members
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addMemberBtn);
            Name = "uc_Members";
            Size = new Size(1013, 542);
            ResumeLayout(false);
        }

        #endregion

        private Button addMemberBtn;
    }
}
