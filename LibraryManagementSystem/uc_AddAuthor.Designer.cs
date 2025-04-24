namespace LibraryManagementSystem
{
    partial class uc_AddAuthor
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
            addAuthorLabel = new Label();
            authorFNLabel = new Label();
            authorFNtb = new TextBox();
            authorLNtb = new TextBox();
            label1 = new Label();
            discardAuthorBtn = new Button();
            saveAuthorBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(addAuthorLabel);
            panel1.Location = new Point(45, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 74);
            panel1.TabIndex = 3;
            // 
            // addAuthorLabel
            // 
            addAuthorLabel.AutoSize = true;
            addAuthorLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAuthorLabel.Location = new Point(37, 22);
            addAuthorLabel.Name = "addAuthorLabel";
            addAuthorLabel.Size = new Size(262, 32);
            addAuthorLabel.TabIndex = 0;
            addAuthorLabel.Text = "Add a New Author";
            // 
            // authorFNLabel
            // 
            authorFNLabel.AutoSize = true;
            authorFNLabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorFNLabel.Location = new Point(87, 143);
            authorFNLabel.Name = "authorFNLabel";
            authorFNLabel.Size = new Size(133, 27);
            authorFNLabel.TabIndex = 4;
            authorFNLabel.Text = "First Name";
            // 
            // authorFNtb
            // 
            authorFNtb.BackColor = Color.LemonChiffon;
            authorFNtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorFNtb.Location = new Point(95, 187);
            authorFNtb.Name = "authorFNtb";
            authorFNtb.Size = new Size(263, 31);
            authorFNtb.TabIndex = 5;
            // 
            // authorLNtb
            // 
            authorLNtb.BackColor = Color.LemonChiffon;
            authorLNtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorLNtb.Location = new Point(95, 317);
            authorLNtb.Name = "authorLNtb";
            authorLNtb.Size = new Size(263, 31);
            authorLNtb.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 273);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 6;
            label1.Text = "Last Name";
            // 
            // discardAuthorBtn
            // 
            discardAuthorBtn.BackColor = SystemColors.ButtonHighlight;
            discardAuthorBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardAuthorBtn.BackgroundImageLayout = ImageLayout.Center;
            discardAuthorBtn.Location = new Point(806, 390);
            discardAuthorBtn.Name = "discardAuthorBtn";
            discardAuthorBtn.Size = new Size(98, 64);
            discardAuthorBtn.TabIndex = 10;
            discardAuthorBtn.UseVisualStyleBackColor = false;
            discardAuthorBtn.Click += discardAuthorBtn_Click;
            // 
            // saveAuthorBtn
            // 
            saveAuthorBtn.BackColor = SystemColors.ButtonHighlight;
            saveAuthorBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveAuthorBtn.BackgroundImageLayout = ImageLayout.Center;
            saveAuthorBtn.Location = new Point(688, 390);
            saveAuthorBtn.Name = "saveAuthorBtn";
            saveAuthorBtn.Size = new Size(98, 64);
            saveAuthorBtn.TabIndex = 9;
            saveAuthorBtn.UseVisualStyleBackColor = false;
            saveAuthorBtn.Click += saveAuthorBtn_Click;
            // 
            // uc_AddAuthor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardAuthorBtn);
            Controls.Add(saveAuthorBtn);
            Controls.Add(authorLNtb);
            Controls.Add(label1);
            Controls.Add(authorFNtb);
            Controls.Add(authorFNLabel);
            Controls.Add(panel1);
            Name = "uc_AddAuthor";
            Size = new Size(1013, 542);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label addAuthorLabel;
        private Label authorFNLabel;
        private TextBox authorFNtb;
        private TextBox authorLNtb;
        private Label label1;
        private Button discardAuthorBtn;
        private Button saveAuthorBtn;
    }
}
