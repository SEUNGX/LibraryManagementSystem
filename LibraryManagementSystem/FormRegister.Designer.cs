namespace LibraryManagementSystem
{
    partial class FormRegister
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbUsername = new TextBox();
            tbEmail = new TextBox();
            tblName = new TextBox();
            tbfName = new TextBox();
            tbPassword = new TextBox();
            cbRole = new ComboBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(51, 29);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(98, 27);
            tbUsername.TabIndex = 0;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(330, 39);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(98, 27);
            tbEmail.TabIndex = 2;
            // 
            // tblName
            // 
            tblName.Location = new Point(195, 91);
            tblName.Name = "tblName";
            tblName.Size = new Size(98, 27);
            tblName.TabIndex = 3;
            // 
            // tbfName
            // 
            tbfName.Location = new Point(195, 29);
            tbfName.Name = "tbfName";
            tbfName.Size = new Size(98, 27);
            tbfName.TabIndex = 4;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(51, 91);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(98, 27);
            tbPassword.TabIndex = 5;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Admin", "Librarian", "Staff" });
            cbRole.Location = new Point(330, 91);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(110, 28);
            cbRole.TabIndex = 6;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(417, 228);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(168, 73);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "button1";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(cbRole);
            Controls.Add(tbPassword);
            Controls.Add(tbfName);
            Controls.Add(tblName);
            Controls.Add(tbEmail);
            Controls.Add(tbUsername);
            Name = "FormRegister";
            Text = "FormRegister";
            Load += FormRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbEmail;
        private TextBox tblName;
        private TextBox tbfName;
        private TextBox tbPassword;
        private ComboBox cbRole;
        private Button btnRegister;
    }
}