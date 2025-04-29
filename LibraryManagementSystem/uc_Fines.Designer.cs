namespace LibraryManagementSystem
{
    partial class uc_Fines
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            waivedFinesBtn = new Button();
            unpaidFinesBtn = new Button();
            paidFinesBtn = new Button();
            allFinesBtn = new Button();
            setPaidBtn = new Button();
            editBtn = new Button();
            finesDgv = new DataGridView();
            panel1 = new Panel();
            searchBox = new TextBox();
            searchBtn = new Button();
            waiveBtn = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)finesDgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(waivedFinesBtn);
            panel2.Controls.Add(unpaidFinesBtn);
            panel2.Controls.Add(paidFinesBtn);
            panel2.Controls.Add(allFinesBtn);
            panel2.Location = new Point(49, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 41);
            panel2.TabIndex = 2;
            // 
            // waivedFinesBtn
            // 
            waivedFinesBtn.BackColor = Color.White;
            waivedFinesBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            waivedFinesBtn.ForeColor = Color.DarkGoldenrod;
            waivedFinesBtn.Location = new Point(251, 0);
            waivedFinesBtn.Name = "waivedFinesBtn";
            waivedFinesBtn.Size = new Size(108, 41);
            waivedFinesBtn.TabIndex = 3;
            waivedFinesBtn.Text = "Waived";
            waivedFinesBtn.UseVisualStyleBackColor = false;
            waivedFinesBtn.Click += waivedFinesBtn_Click;
            // 
            // unpaidFinesBtn
            // 
            unpaidFinesBtn.BackColor = Color.White;
            unpaidFinesBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            unpaidFinesBtn.ForeColor = Color.DarkGoldenrod;
            unpaidFinesBtn.Location = new Point(154, 0);
            unpaidFinesBtn.Name = "unpaidFinesBtn";
            unpaidFinesBtn.Size = new Size(91, 41);
            unpaidFinesBtn.TabIndex = 2;
            unpaidFinesBtn.Text = "Unpaid";
            unpaidFinesBtn.UseVisualStyleBackColor = false;
            unpaidFinesBtn.Click += unpaidFinesBtn_Click;
            // 
            // paidFinesBtn
            // 
            paidFinesBtn.BackColor = Color.White;
            paidFinesBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            paidFinesBtn.ForeColor = Color.DarkGoldenrod;
            paidFinesBtn.Location = new Point(76, 0);
            paidFinesBtn.Name = "paidFinesBtn";
            paidFinesBtn.Size = new Size(72, 41);
            paidFinesBtn.TabIndex = 1;
            paidFinesBtn.Text = "Paid";
            paidFinesBtn.UseVisualStyleBackColor = false;
            paidFinesBtn.Click += paidFinesBtn_Click;
            // 
            // allFinesBtn
            // 
            allFinesBtn.BackColor = Color.White;
            allFinesBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            allFinesBtn.ForeColor = Color.DarkGoldenrod;
            allFinesBtn.Location = new Point(0, 0);
            allFinesBtn.Name = "allFinesBtn";
            allFinesBtn.Size = new Size(70, 41);
            allFinesBtn.TabIndex = 0;
            allFinesBtn.Text = "All";
            allFinesBtn.UseVisualStyleBackColor = false;
            allFinesBtn.Click += allFinesBtn_Click;
            // 
            // setPaidBtn
            // 
            setPaidBtn.BackColor = Color.White;
            setPaidBtn.BackgroundImage = Properties.Resources.icons8_pay_30;
            setPaidBtn.BackgroundImageLayout = ImageLayout.Center;
            setPaidBtn.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setPaidBtn.Location = new Point(786, 3);
            setPaidBtn.Name = "setPaidBtn";
            setPaidBtn.Size = new Size(50, 62);
            setPaidBtn.TabIndex = 5;
            setPaidBtn.Text = "Paid";
            setPaidBtn.TextAlign = ContentAlignment.BottomCenter;
            setPaidBtn.UseVisualStyleBackColor = false;
            setPaidBtn.Click += setPaidBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.White;
            editBtn.BackgroundImage = Properties.Resources.icons8_edit_30;
            editBtn.BackgroundImageLayout = ImageLayout.Center;
            editBtn.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editBtn.Location = new Point(842, 3);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(50, 62);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.TextAlign = ContentAlignment.BottomCenter;
            editBtn.UseVisualStyleBackColor = false;
            // 
            // finesDgv
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            finesDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            finesDgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            finesDgv.BackgroundColor = Color.Linen;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle2.Font = new Font("Arial", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            finesDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            finesDgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Khaki;
            dataGridViewCellStyle3.Font = new Font("Arial", 8F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(200, 230, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            finesDgv.DefaultCellStyle = dataGridViewCellStyle3;
            finesDgv.Dock = DockStyle.Fill;
            finesDgv.EnableHeadersVisualStyles = false;
            finesDgv.Font = new Font("Arial", 8F);
            finesDgv.GridColor = Color.LightGray;
            finesDgv.Location = new Point(0, 0);
            finesDgv.Name = "finesDgv";
            finesDgv.ReadOnly = true;
            finesDgv.RowHeadersWidth = 51;
            finesDgv.RowTemplate.Height = 30;
            finesDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            finesDgv.Size = new Size(899, 438);
            finesDgv.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(finesDgv);
            panel1.Location = new Point(49, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(899, 438);
            panel1.TabIndex = 1;
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.Location = new Point(414, 20);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(294, 41);
            searchBox.TabIndex = 6;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.White;
            searchBtn.BackgroundImage = Properties.Resources.icons8_search_30;
            searchBtn.BackgroundImageLayout = ImageLayout.Center;
            searchBtn.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBtn.Location = new Point(704, 20);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(50, 41);
            searchBtn.TabIndex = 7;
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // waiveBtn
            // 
            waiveBtn.BackColor = Color.White;
            waiveBtn.BackgroundImage = Properties.Resources.icons8_cancel_30;
            waiveBtn.BackgroundImageLayout = ImageLayout.Center;
            waiveBtn.Font = new Font("Arial Rounded MT Bold", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            waiveBtn.Location = new Point(898, 3);
            waiveBtn.Name = "waiveBtn";
            waiveBtn.Size = new Size(50, 62);
            waiveBtn.TabIndex = 8;
            waiveBtn.Text = "Waive";
            waiveBtn.TextAlign = ContentAlignment.BottomCenter;
            waiveBtn.UseVisualStyleBackColor = false;
            waiveBtn.Click += waiveBtn_Click;
            // 
            // uc_Fines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(waiveBtn);
            Controls.Add(searchBtn);
            Controls.Add(searchBox);
            Controls.Add(setPaidBtn);
            Controls.Add(panel2);
            Controls.Add(editBtn);
            Controls.Add(panel1);
            Name = "uc_Fines";
            Size = new Size(1013, 542);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)finesDgv).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button editBtn;
        private Button unpaidFinesBtn;
        private Button paidFinesBtn;
        private Button allFinesBtn;
        private Button setPaidBtn;
        private DataGridView finesDgv;
        private Panel panel1;
        private TextBox searchBox;
        private Button searchBtn;
        private Button waivedFinesBtn;
        private Button waiveBtn;
    }
}
