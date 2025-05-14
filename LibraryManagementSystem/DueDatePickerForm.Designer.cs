namespace LibraryManagementSystem
{
    partial class DueDatePickerForm
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
            dueDatePicker = new DateTimePicker();
            cancelBtn = new Button();
            okBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // dueDatePicker
            // 
            dueDatePicker.CalendarFont = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDatePicker.CalendarForeColor = Color.SaddleBrown;
            dueDatePicker.CalendarTitleForeColor = Color.SaddleBrown;
            dueDatePicker.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dueDatePicker.Format = DateTimePickerFormat.Short;
            dueDatePicker.Location = new Point(25, 74);
            dueDatePicker.Name = "dueDatePicker";
            dueDatePicker.Size = new Size(250, 31);
            dueDatePicker.TabIndex = 0;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ButtonHighlight;
            cancelBtn.BackgroundImage = Properties.Resources.icons8_cancel_40;
            cancelBtn.BackgroundImageLayout = ImageLayout.Center;
            cancelBtn.Location = new Point(272, 154);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(98, 64);
            cancelBtn.TabIndex = 15;
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // okBtn
            // 
            okBtn.BackColor = SystemColors.ButtonHighlight;
            okBtn.BackgroundImage = Properties.Resources.icons8_save_40;
            okBtn.BackgroundImageLayout = ImageLayout.Center;
            okBtn.Location = new Point(168, 154);
            okBtn.Name = "okBtn";
            okBtn.Size = new Size(98, 64);
            okBtn.TabIndex = 14;
            okBtn.UseVisualStyleBackColor = false;
            okBtn.Click += okBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(218, 32);
            label1.TabIndex = 16;
            label1.Text = "Set a Due Date";
            // 
            // DueDatePickerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 253);
            Controls.Add(label1);
            Controls.Add(cancelBtn);
            Controls.Add(okBtn);
            Controls.Add(dueDatePicker);
            Location = new Point(200, 100);
            Name = "DueDatePickerForm";
            Text = "DueDatePickerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dueDatePicker;
        private Button cancelBtn;
        private Button okBtn;
        private Label label1;
    }
}