namespace LibraryManagementSystem
{
    partial class uc_userLibrarians
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
            addLibrarianBtn = new Button();
            SuspendLayout();
            // 
            // addLibrarianBtn
            // 
            addLibrarianBtn.BackColor = SystemColors.ButtonHighlight;
            addLibrarianBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLibrarianBtn.Image = Properties.Resources.icons8_glasses_64;
            addLibrarianBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addLibrarianBtn.Location = new Point(782, 430);
            addLibrarianBtn.Name = "addLibrarianBtn";
            addLibrarianBtn.Size = new Size(175, 65);
            addLibrarianBtn.TabIndex = 1;
            addLibrarianBtn.Text = "             Add\r\n             Librarian";
            addLibrarianBtn.TextAlign = ContentAlignment.MiddleLeft;
            addLibrarianBtn.UseVisualStyleBackColor = false;
            addLibrarianBtn.Click += addLibrarianBtn_Click;
            // 
            // uc_userLibrarians
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addLibrarianBtn);
            Name = "uc_userLibrarians";
            Size = new Size(1013, 542);
            ResumeLayout(false);
        }

        #endregion

        private Button addLibrarianBtn;
    }
}
