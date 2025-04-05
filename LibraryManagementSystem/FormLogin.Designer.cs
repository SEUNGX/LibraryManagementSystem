namespace LibraryManagementSystem
{
    partial class FormLogin
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
            tbPassword = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            btnRegister = new Button();
            panel1 = new Panel();
            welcomeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.OldLace;
            tbUsername.Location = new Point(134, 160);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(274, 38);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.OldLace;
            tbPassword.Location = new Point(134, 241);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(274, 40);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameLabel.ForeColor = Color.SaddleBrown;
            usernameLabel.Location = new Point(134, 126);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(111, 23);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.SaddleBrown;
            passwordLabel.Location = new Point(134, 204);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(107, 23);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Bisque;
            btnRegister.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Sienna;
            btnRegister.Location = new Point(191, 306);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(162, 55);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Login";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(welcomeLabel);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Location = new Point(307, 93);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 466);
            panel1.TabIndex = 5;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.SaddleBrown;
            welcomeLabel.Location = new Point(89, 55);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(365, 34);
            welcomeLabel.TabIndex = 5;
            welcomeLabel.Text = "Welcome to the Library!";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BG_LOGIN_1;
            ClientSize = new Size(1155, 643);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbUsername;
        private TextBox tbPassword;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button btnRegister;
        private Panel panel1;
        private Label welcomeLabel;
    }
}