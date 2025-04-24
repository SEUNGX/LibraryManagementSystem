namespace LibraryManagementSystem
{
    partial class uc_Category
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
            addCategoryLabel = new Label();
            categoryNameLabel = new Label();
            categoryDescriptionLabel = new Label();
            categoryTb = new TextBox();
            categoryDescriptionTb = new TextBox();
            saveCategoryBtn = new Button();
            discardCategoryBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SkyBlue;
            panel1.Controls.Add(addCategoryLabel);
            panel1.Location = new Point(46, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 74);
            panel1.TabIndex = 2;
            // 
            // addCategoryLabel
            // 
            addCategoryLabel.AutoSize = true;
            addCategoryLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCategoryLabel.Location = new Point(37, 22);
            addCategoryLabel.Name = "addCategoryLabel";
            addCategoryLabel.Size = new Size(296, 32);
            addCategoryLabel.TabIndex = 0;
            addCategoryLabel.Text = "Add a New Category";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryNameLabel.Location = new Point(46, 175);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(115, 27);
            categoryNameLabel.TabIndex = 3;
            categoryNameLabel.Text = "Category";
            // 
            // categoryDescriptionLabel
            // 
            categoryDescriptionLabel.AutoSize = true;
            categoryDescriptionLabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryDescriptionLabel.Location = new Point(46, 299);
            categoryDescriptionLabel.Name = "categoryDescriptionLabel";
            categoryDescriptionLabel.Size = new Size(141, 27);
            categoryDescriptionLabel.TabIndex = 4;
            categoryDescriptionLabel.Text = "Description";
            // 
            // categoryTb
            // 
            categoryTb.BackColor = Color.LightCyan;
            categoryTb.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryTb.Location = new Point(46, 217);
            categoryTb.Name = "categoryTb";
            categoryTb.Size = new Size(211, 34);
            categoryTb.TabIndex = 5;
            // 
            // categoryDescriptionTb
            // 
            categoryDescriptionTb.BackColor = Color.LightCyan;
            categoryDescriptionTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryDescriptionTb.Location = new Point(46, 343);
            categoryDescriptionTb.Multiline = true;
            categoryDescriptionTb.Name = "categoryDescriptionTb";
            categoryDescriptionTb.Size = new Size(553, 111);
            categoryDescriptionTb.TabIndex = 6;
            // 
            // saveCategoryBtn
            // 
            saveCategoryBtn.BackColor = SystemColors.ButtonHighlight;
            saveCategoryBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveCategoryBtn.BackgroundImageLayout = ImageLayout.Center;
            saveCategoryBtn.Location = new Point(736, 364);
            saveCategoryBtn.Name = "saveCategoryBtn";
            saveCategoryBtn.Size = new Size(98, 64);
            saveCategoryBtn.TabIndex = 7;
            saveCategoryBtn.UseVisualStyleBackColor = false;
            saveCategoryBtn.Click += saveCategoryBtn_Click;
            // 
            // discardCategoryBtn
            // 
            discardCategoryBtn.BackColor = SystemColors.ButtonHighlight;
            discardCategoryBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardCategoryBtn.BackgroundImageLayout = ImageLayout.Center;
            discardCategoryBtn.Location = new Point(840, 364);
            discardCategoryBtn.Name = "discardCategoryBtn";
            discardCategoryBtn.Size = new Size(98, 64);
            discardCategoryBtn.TabIndex = 8;
            discardCategoryBtn.UseVisualStyleBackColor = false;
            discardCategoryBtn.Click += discardCategoryBtn_Click;
            // 
            // uc_Category
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardCategoryBtn);
            Controls.Add(saveCategoryBtn);
            Controls.Add(categoryDescriptionTb);
            Controls.Add(categoryTb);
            Controls.Add(categoryDescriptionLabel);
            Controls.Add(categoryNameLabel);
            Controls.Add(panel1);
            Name = "uc_Category";
            Size = new Size(1013, 542);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label addCategoryLabel;
        private Label categoryNameLabel;
        private Label categoryDescriptionLabel;
        private TextBox categoryTb;
        private TextBox categoryDescriptionTb;
        private Button saveCategoryBtn;
        private Button discardCategoryBtn;
    }
}
