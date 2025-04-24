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
            btnLogin = new Button();
            panel1 = new Panel();
            welcomeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbUsername
            // 
            tbUsername.BackColor = Color.OldLace;
            tbUsername.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(134, 160);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(274, 38);
            tbUsername.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = Color.OldLace;
            tbPassword.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(134, 241);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(274, 31);
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
            // btnLogin
            // 
            btnLogin.BackColor = Color.Bisque;
            btnLogin.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Sienna;
            btnLogin.Location = new Point(191, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(162, 55);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AntiqueWhite;
            panel1.Controls.Add(welcomeLabel);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(usernameLabel);
            panel1.Controls.Add(tbPassword);
            panel1.Controls.Add(tbUsername);
            panel1.Location = new Point(293, 122);
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
            ClientSize = new Size(1120, 679);
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
        private Button btnLogin;
        private Panel panel1;
        private Label welcomeLabel;
    }
}