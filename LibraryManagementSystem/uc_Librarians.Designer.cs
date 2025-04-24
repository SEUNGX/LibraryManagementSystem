namespace LibraryManagementSystem
{
    partial class uc_Librarians
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
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            librarianFNtb = new TextBox();
            librarianLNtb = new TextBox();
            label3 = new Label();
            librarianEmailtb = new TextBox();
            label4 = new Label();
            librarianUNtb = new TextBox();
            label5 = new Label();
            librarianPasstb = new TextBox();
            label6 = new Label();
            saveLibrarianBtn = new Button();
            discardLibrarianBtn = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 491);
            panel1.Name = "panel1";
            panel1.Size = new Size(1013, 51);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleGreen;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1013, 53);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 67);
            label1.Name = "label1";
            label1.Size = new Size(325, 34);
            label1.TabIndex = 2;
            label1.Text = "Add a New Librarian!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 128);
            label2.Name = "label2";
            label2.Size = new Size(133, 27);
            label2.TabIndex = 3;
            label2.Text = "First Name";
            // 
            // librarianFNtb
            // 
            librarianFNtb.BackColor = Color.Honeydew;
            librarianFNtb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librarianFNtb.Location = new Point(64, 169);
            librarianFNtb.Name = "librarianFNtb";
            librarianFNtb.Size = new Size(270, 34);
            librarianFNtb.TabIndex = 4;
            // 
            // librarianLNtb
            // 
            librarianLNtb.BackColor = Color.Honeydew;
            librarianLNtb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librarianLNtb.Location = new Point(64, 268);
            librarianLNtb.Name = "librarianLNtb";
            librarianLNtb.Size = new Size(270, 34);
            librarianLNtb.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 227);
            label3.Name = "label3";
            label3.Size = new Size(131, 27);
            label3.TabIndex = 5;
            label3.Text = "Last Name";
            // 
            // librarianEmailtb
            // 
            librarianEmailtb.BackColor = Color.Honeydew;
            librarianEmailtb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librarianEmailtb.Location = new Point(64, 371);
            librarianEmailtb.Name = "librarianEmailtb";
            librarianEmailtb.Size = new Size(270, 34);
            librarianEmailtb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(64, 330);
            label4.Name = "label4";
            label4.Size = new Size(73, 27);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // librarianUNtb
            // 
            librarianUNtb.BackColor = Color.Honeydew;
            librarianUNtb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librarianUNtb.Location = new Point(500, 169);
            librarianUNtb.Name = "librarianUNtb";
            librarianUNtb.Size = new Size(270, 34);
            librarianUNtb.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(500, 128);
            label5.Name = "label5";
            label5.Size = new Size(127, 27);
            label5.TabIndex = 9;
            label5.Text = "Username";
            // 
            // librarianPasstb
            // 
            librarianPasstb.BackColor = Color.Honeydew;
            librarianPasstb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librarianPasstb.Location = new Point(500, 268);
            librarianPasstb.Name = "librarianPasstb";
            librarianPasstb.Size = new Size(270, 34);
            librarianPasstb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(500, 227);
            label6.Name = "label6";
            label6.Size = new Size(122, 27);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // saveLibrarianBtn
            // 
            saveLibrarianBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveLibrarianBtn.BackgroundImageLayout = ImageLayout.Center;
            saveLibrarianBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveLibrarianBtn.Location = new Point(730, 395);
            saveLibrarianBtn.Name = "saveLibrarianBtn";
            saveLibrarianBtn.Size = new Size(98, 64);
            saveLibrarianBtn.TabIndex = 13;
            saveLibrarianBtn.TextAlign = ContentAlignment.MiddleRight;
            saveLibrarianBtn.UseVisualStyleBackColor = true;
            saveLibrarianBtn.Click += saveLibrarianBtn_Click;
            // 
            // discardLibrarianBtn
            // 
            discardLibrarianBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardLibrarianBtn.BackgroundImageLayout = ImageLayout.Center;
            discardLibrarianBtn.Location = new Point(834, 395);
            discardLibrarianBtn.Name = "discardLibrarianBtn";
            discardLibrarianBtn.Size = new Size(87, 64);
            discardLibrarianBtn.TabIndex = 14;
            discardLibrarianBtn.UseVisualStyleBackColor = true;
            discardLibrarianBtn.Click += discardLibrarianBtn_Click;
            // 
            // uc_Librarians
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardLibrarianBtn);
            Controls.Add(saveLibrarianBtn);
            Controls.Add(librarianPasstb);
            Controls.Add(label6);
            Controls.Add(librarianUNtb);
            Controls.Add(label5);
            Controls.Add(librarianEmailtb);
            Controls.Add(label4);
            Controls.Add(librarianLNtb);
            Controls.Add(label3);
            Controls.Add(librarianFNtb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "uc_Librarians";
            Size = new Size(1013, 542);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox librarianFNtb;
        private TextBox librarianLNtb;
        private Label label3;
        private TextBox librarianEmailtb;
        private Label label4;
        private TextBox librarianUNtb;
        private Label label5;
        private TextBox librarianPasstb;
        private Label label6;
        private Button saveLibrarianBtn;
        private Button discardLibrarianBtn;
    }
}
