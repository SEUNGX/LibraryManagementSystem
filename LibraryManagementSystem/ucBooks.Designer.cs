namespace LibraryManagementSystem
{
    partial class ucBooks
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
            addBookBtn = new Button();
            addCategoryBtn = new Button();
            addAuthorBtn = new Button();
            SuspendLayout();
            // 
            // addBookBtn
            // 
            addBookBtn.BackColor = Color.LightGreen;
            addBookBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookBtn.Image = Properties.Resources.icons8_book_40;
            addBookBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addBookBtn.Location = new Point(820, 448);
            addBookBtn.Name = "addBookBtn";
            addBookBtn.Size = new Size(141, 65);
            addBookBtn.TabIndex = 0;
            addBookBtn.Text = "Add Book";
            addBookBtn.TextAlign = ContentAlignment.MiddleRight;
            addBookBtn.UseVisualStyleBackColor = false;
            addBookBtn.Click += addBookBtn_Click;
            // 
            // addCategoryBtn
            // 
            addCategoryBtn.BackColor = Color.SkyBlue;
            addCategoryBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategoryBtn.Image = Properties.Resources.icons8_book_40;
            addCategoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addCategoryBtn.Location = new Point(820, 377);
            addCategoryBtn.Name = "addCategoryBtn";
            addCategoryBtn.Size = new Size(141, 65);
            addCategoryBtn.TabIndex = 1;
            addCategoryBtn.Text = "        Add \r\n        Category";
            addCategoryBtn.TextAlign = ContentAlignment.MiddleLeft;
            addCategoryBtn.UseVisualStyleBackColor = false;
            addCategoryBtn.Click += addCategoryBtn_Click;
            // 
            // addAuthorBtn
            // 
            addAuthorBtn.BackColor = Color.LightGoldenrodYellow;
            addAuthorBtn.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAuthorBtn.Image = Properties.Resources.icons8_book_40;
            addAuthorBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addAuthorBtn.Location = new Point(820, 306);
            addAuthorBtn.Name = "addAuthorBtn";
            addAuthorBtn.Size = new Size(141, 65);
            addAuthorBtn.TabIndex = 2;
            addAuthorBtn.Text = "        Add \r\n        Author";
            addAuthorBtn.TextAlign = ContentAlignment.MiddleLeft;
            addAuthorBtn.UseVisualStyleBackColor = false;
            addAuthorBtn.Click += addAuthorBtn_Click;
            // 
            // ucBooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addAuthorBtn);
            Controls.Add(addCategoryBtn);
            Controls.Add(addBookBtn);
            Name = "ucBooks";
            Size = new Size(1013, 542);
            ResumeLayout(false);
        }

        #endregion

        private Button addBookBtn;
        private Button addCategoryBtn;
        private Button addAuthorBtn;
    }
}
