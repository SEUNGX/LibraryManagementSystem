namespace LibraryManagementSystem
{
    partial class uc_AddMember
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
            memberFNlabel = new Label();
            memberFNtb = new TextBox();
            memberLNtb = new TextBox();
            label1 = new Label();
            memberPhonetb = new TextBox();
            label2 = new Label();
            memberEmailtb = new TextBox();
            label3 = new Label();
            memberBirthdatePicker = new DateTimePicker();
            label4 = new Label();
            memberAddresstb = new TextBox();
            label5 = new Label();
            discardMemberBtn = new Button();
            saveMemberBtn = new Button();
            SuspendLayout();
            // 
            // memberFNlabel
            // 
            memberFNlabel.AutoSize = true;
            memberFNlabel.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberFNlabel.Location = new Point(77, 89);
            memberFNlabel.Name = "memberFNlabel";
            memberFNlabel.Size = new Size(133, 27);
            memberFNlabel.TabIndex = 0;
            memberFNlabel.Text = "First Name";
            // 
            // memberFNtb
            // 
            memberFNtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberFNtb.Location = new Point(77, 132);
            memberFNtb.Name = "memberFNtb";
            memberFNtb.Size = new Size(330, 31);
            memberFNtb.TabIndex = 1;
            // 
            // memberLNtb
            // 
            memberLNtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberLNtb.Location = new Point(463, 132);
            memberLNtb.Name = "memberLNtb";
            memberLNtb.Size = new Size(319, 31);
            memberLNtb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(463, 89);
            label1.Name = "label1";
            label1.Size = new Size(131, 27);
            label1.TabIndex = 2;
            label1.Text = "Last Name";
            // 
            // memberPhonetb
            // 
            memberPhonetb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberPhonetb.Location = new Point(507, 243);
            memberPhonetb.Name = "memberPhonetb";
            memberPhonetb.Size = new Size(243, 31);
            memberPhonetb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(507, 200);
            label2.Name = "label2";
            label2.Size = new Size(178, 27);
            label2.TabIndex = 4;
            label2.Text = "Phone Number";
            // 
            // memberEmailtb
            // 
            memberEmailtb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberEmailtb.Location = new Point(80, 243);
            memberEmailtb.Name = "memberEmailtb";
            memberEmailtb.Size = new Size(393, 31);
            memberEmailtb.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 200);
            label3.Name = "label3";
            label3.Size = new Size(73, 27);
            label3.TabIndex = 6;
            label3.Text = "Email";
            // 
            // memberBirthdatePicker
            // 
            memberBirthdatePicker.Location = new Point(79, 441);
            memberBirthdatePicker.Name = "memberBirthdatePicker";
            memberBirthdatePicker.Size = new Size(250, 27);
            memberBirthdatePicker.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(79, 394);
            label4.Name = "label4";
            label4.Size = new Size(154, 27);
            label4.TabIndex = 9;
            label4.Text = "Date of Birth";
            // 
            // memberAddresstb
            // 
            memberAddresstb.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            memberAddresstb.Location = new Point(79, 336);
            memberAddresstb.Name = "memberAddresstb";
            memberAddresstb.Size = new Size(757, 31);
            memberAddresstb.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 293);
            label5.Name = "label5";
            label5.Size = new Size(105, 27);
            label5.TabIndex = 10;
            label5.Text = "Address";
            // 
            // discardMemberBtn
            // 
            discardMemberBtn.BackColor = SystemColors.ButtonHighlight;
            discardMemberBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            discardMemberBtn.BackgroundImageLayout = ImageLayout.Center;
            discardMemberBtn.Location = new Point(848, 424);
            discardMemberBtn.Name = "discardMemberBtn";
            discardMemberBtn.Size = new Size(98, 64);
            discardMemberBtn.TabIndex = 13;
            discardMemberBtn.UseVisualStyleBackColor = false;
            discardMemberBtn.Click += discardMemberBtn_Click;
            // 
            // saveMemberBtn
            // 
            saveMemberBtn.BackColor = SystemColors.ButtonHighlight;
            saveMemberBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            saveMemberBtn.BackgroundImageLayout = ImageLayout.Center;
            saveMemberBtn.Location = new Point(744, 424);
            saveMemberBtn.Name = "saveMemberBtn";
            saveMemberBtn.Size = new Size(98, 64);
            saveMemberBtn.TabIndex = 12;
            saveMemberBtn.UseVisualStyleBackColor = false;
            saveMemberBtn.Click += saveMemberBtn_Click;
            // 
            // uc_AddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(discardMemberBtn);
            Controls.Add(saveMemberBtn);
            Controls.Add(memberAddresstb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(memberBirthdatePicker);
            Controls.Add(memberEmailtb);
            Controls.Add(label3);
            Controls.Add(memberPhonetb);
            Controls.Add(label2);
            Controls.Add(memberLNtb);
            Controls.Add(label1);
            Controls.Add(memberFNtb);
            Controls.Add(memberFNlabel);
            Name = "uc_AddMember";
            Size = new Size(1013, 542);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberFNlabel;
        private TextBox memberFNtb;
        private TextBox memberLNtb;
        private Label label1;
        private TextBox memberPhonetb;
        private Label label2;
        private TextBox memberEmailtb;
        private Label label3;
        private DateTimePicker memberBirthdatePicker;
        private Label label4;
        private TextBox memberAddresstb;
        private Label label5;
        private Button discardMemberBtn;
        private Button saveMemberBtn;
    }
}
