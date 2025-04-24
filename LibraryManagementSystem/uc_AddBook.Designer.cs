namespace LibraryManagementSystem
{
    partial class uc_AddBook
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
            addBookLabel = new Label();
            panel1 = new Panel();
            ISBNtb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            titleTb = new TextBox();
            label3 = new Label();
            editionTb = new TextBox();
            authorCb = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            pubYearTb = new TextBox();
            label6 = new Label();
            publisherTb = new TextBox();
            label7 = new Label();
            totalCopiesTb = new TextBox();
            label10 = new Label();
            descriptionTb = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            discardBookBtn = new Button();
            saveBookBtn = new Button();
            label9 = new Label();
            categoryCb = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // addBookLabel
            // 
            addBookLabel.AutoSize = true;
            addBookLabel.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBookLabel.Location = new Point(37, 22);
            addBookLabel.Name = "addBookLabel";
            addBookLabel.Size = new Size(239, 32);
            addBookLabel.TabIndex = 0;
            addBookLabel.Text = "Add a New Book";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGreen;
            panel1.Controls.Add(addBookLabel);
            panel1.Location = new Point(38, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(307, 74);
            panel1.TabIndex = 1;
            // 
            // ISBNtb
            // 
            ISBNtb.BackColor = Color.Honeydew;
            ISBNtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ISBNtb.Location = new Point(70, 142);
            ISBNtb.Name = "ISBNtb";
            ISBNtb.Size = new Size(207, 31);
            ISBNtb.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(70, 112);
            label1.Name = "label1";
            label1.Size = new Size(68, 27);
            label1.TabIndex = 3;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 112);
            label2.Name = "label2";
            label2.Size = new Size(60, 27);
            label2.TabIndex = 5;
            label2.Text = "Title";
            // 
            // titleTb
            // 
            titleTb.BackColor = Color.Honeydew;
            titleTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleTb.Location = new Point(320, 142);
            titleTb.Name = "titleTb";
            titleTb.Size = new Size(558, 31);
            titleTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(671, 193);
            label3.Name = "label3";
            label3.Size = new Size(89, 27);
            label3.TabIndex = 7;
            label3.Text = "Edition";
            // 
            // editionTb
            // 
            editionTb.BackColor = Color.Honeydew;
            editionTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editionTb.Location = new Point(671, 223);
            editionTb.Name = "editionTb";
            editionTb.Size = new Size(207, 31);
            editionTb.TabIndex = 6;
            // 
            // authorCb
            // 
            authorCb.BackColor = Color.Honeydew;
            authorCb.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            authorCb.FormattingEnabled = true;
            authorCb.Location = new Point(70, 311);
            authorCb.Name = "authorCb";
            authorCb.Size = new Size(279, 29);
            authorCb.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(76, 270);
            label4.Name = "label4";
            label4.Size = new Size(89, 27);
            label4.TabIndex = 9;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(448, 193);
            label5.Name = "label5";
            label5.Size = new Size(195, 27);
            label5.TabIndex = 13;
            label5.Text = "Publication Year";
            // 
            // pubYearTb
            // 
            pubYearTb.BackColor = Color.Honeydew;
            pubYearTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pubYearTb.Location = new Point(448, 223);
            pubYearTb.Name = "pubYearTb";
            pubYearTb.Size = new Size(195, 31);
            pubYearTb.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(70, 193);
            label6.Name = "label6";
            label6.Size = new Size(117, 27);
            label6.TabIndex = 11;
            label6.Text = "Publisher";
            // 
            // publisherTb
            // 
            publisherTb.BackColor = Color.Honeydew;
            publisherTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            publisherTb.Location = new Point(70, 223);
            publisherTb.Name = "publisherTb";
            publisherTb.Size = new Size(345, 31);
            publisherTb.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(671, 270);
            label7.Name = "label7";
            label7.Size = new Size(151, 27);
            label7.TabIndex = 17;
            label7.Text = "Total Copies";
            // 
            // totalCopiesTb
            // 
            totalCopiesTb.BackColor = Color.Honeydew;
            totalCopiesTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalCopiesTb.Location = new Point(671, 309);
            totalCopiesTb.Name = "totalCopiesTb";
            totalCopiesTb.Size = new Size(207, 31);
            totalCopiesTb.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(76, 354);
            label10.Name = "label10";
            label10.Size = new Size(141, 27);
            label10.TabIndex = 19;
            label10.Text = "Description";
            // 
            // descriptionTb
            // 
            descriptionTb.BackColor = Color.Honeydew;
            descriptionTb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionTb.Location = new Point(76, 393);
            descriptionTb.Multiline = true;
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(671, 109);
            descriptionTb.TabIndex = 18;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // discardBookBtn
            // 
            discardBookBtn.BackColor = SystemColors.ButtonHighlight;
            discardBookBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardBookBtn.BackgroundImageLayout = ImageLayout.Center;
            discardBookBtn.Location = new Point(868, 411);
            discardBookBtn.Name = "discardBookBtn";
            discardBookBtn.Size = new Size(98, 64);
            discardBookBtn.TabIndex = 23;
            discardBookBtn.UseVisualStyleBackColor = false;
            discardBookBtn.Click += discardBookBtn_Click;
            // 
            // saveBookBtn
            // 
            saveBookBtn.BackColor = SystemColors.ButtonHighlight;
            saveBookBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveBookBtn.BackgroundImageLayout = ImageLayout.Center;
            saveBookBtn.Location = new Point(764, 411);
            saveBookBtn.Name = "saveBookBtn";
            saveBookBtn.Size = new Size(98, 64);
            saveBookBtn.TabIndex = 22;
            saveBookBtn.UseVisualStyleBackColor = false;
            saveBookBtn.Click += saveBookBtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(382, 270);
            label9.Name = "label9";
            label9.Size = new Size(115, 27);
            label9.TabIndex = 25;
            label9.Text = "Category";
            // 
            // categoryCb
            // 
            categoryCb.BackColor = Color.Honeydew;
            categoryCb.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryCb.FormattingEnabled = true;
            categoryCb.Location = new Point(376, 311);
            categoryCb.Name = "categoryCb";
            categoryCb.Size = new Size(279, 29);
            categoryCb.TabIndex = 24;
            // 
            // uc_AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(label9);
            Controls.Add(categoryCb);
            Controls.Add(discardBookBtn);
            Controls.Add(saveBookBtn);
            Controls.Add(label10);
            Controls.Add(descriptionTb);
            Controls.Add(label7);
            Controls.Add(totalCopiesTb);
            Controls.Add(label5);
            Controls.Add(pubYearTb);
            Controls.Add(label6);
            Controls.Add(publisherTb);
            Controls.Add(label4);
            Controls.Add(authorCb);
            Controls.Add(label3);
            Controls.Add(editionTb);
            Controls.Add(label2);
            Controls.Add(titleTb);
            Controls.Add(label1);
            Controls.Add(ISBNtb);
            Controls.Add(panel1);
            Name = "uc_AddBook";
            Size = new Size(1013, 542);
            Load += uc_AddBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addBookLabel;
        private Panel panel1;
        private TextBox ISBNtb;
        private Label label1;
        private Label label2;
        private TextBox titleTb;
        private Label label3;
        private TextBox editionTb;
        private ComboBox authorCb;
        private Label label4;
        private Label label5;
        private TextBox pubYearTb;
        private Label label6;
        private TextBox publisherTb;
        private Label label7;
        private TextBox totalCopiesTb;
        private Label label8;
        private TextBox textBox6;
        private Label label10;
        private TextBox descriptionTb;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button discardBookBtn;
        private Button saveBookBtn;
        private Label label9;
        private ComboBox categoryCb;
    }
}
