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
            finesDgv = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)finesDgv).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = Color.Cornsilk;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(49, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 41);
            panel2.TabIndex = 2;
            // 
            // button6
            // 
            button6.BackColor = Color.MediumSeaGreen;
            button6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(617, 0);
            button6.Name = "button6";
            button6.Size = new Size(93, 41);
            button6.TabIndex = 5;
            button6.Text = "Set as Paid";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(806, 0);
            button5.Name = "button5";
            button5.Size = new Size(84, 41);
            button5.TabIndex = 4;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Highlight;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(716, 0);
            button4.Name = "button4";
            button4.Size = new Size(84, 41);
            button4.TabIndex = 3;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SandyBrown;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(306, 0);
            button3.Name = "button3";
            button3.Size = new Size(147, 41);
            button3.TabIndex = 2;
            button3.Text = "Unpaid";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SandyBrown;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(150, 0);
            button2.Name = "button2";
            button2.Size = new Size(150, 41);
            button2.TabIndex = 1;
            button2.Text = "Paid";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(144, 41);
            button1.TabIndex = 0;
            button1.Text = "All";
            button1.UseVisualStyleBackColor = false;
            // 
            // uc_Fines
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "uc_Fines";
            Size = new Size(1013, 542);
            ((System.ComponentModel.ISupportInitialize)finesDgv).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView finesDgv;
        private Panel panel1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button6;
    }
}
