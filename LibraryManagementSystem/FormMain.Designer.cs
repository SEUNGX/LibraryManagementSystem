namespace LibraryManagementSystem
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            hamBtn = new Button();
            LibrarianLabel = new Label();
            mainPanel = new Panel();
            sidebar = new FlowLayoutPanel();
            dashboardBtn = new Button();
            booksBtn = new Button();
            finesBtn = new Button();
            loansBtn = new Button();
            membersBtn = new Button();
            reservationBtn = new Button();
            notificationsBtn = new Button();
            librariansButton = new Button();
            logoutBtn = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            dailyTimer = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tan;
            panel2.Controls.Add(hamBtn);
            panel2.Controls.Add(LibrarianLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1269, 44);
            panel2.TabIndex = 7;
            // 
            // hamBtn
            // 
            hamBtn.Image = Properties.Resources.sidebar_4_32__1_;
            hamBtn.Location = new Point(12, 6);
            hamBtn.Name = "hamBtn";
            hamBtn.Size = new Size(38, 29);
            hamBtn.TabIndex = 9;
            hamBtn.UseVisualStyleBackColor = true;
            hamBtn.Click += hamBtn_Click;
            // 
            // LibrarianLabel
            // 
            LibrarianLabel.AutoSize = true;
            LibrarianLabel.Font = new Font("Arial Rounded MT Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LibrarianLabel.ForeColor = Color.Black;
            LibrarianLabel.Location = new Point(65, 9);
            LibrarianLabel.Name = "LibrarianLabel";
            LibrarianLabel.Size = new Size(154, 21);
            LibrarianLabel.TabIndex = 7;
            LibrarianLabel.Text = "Hello, Librarian!";
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(255, 50);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1013, 542);
            mainPanel.TabIndex = 9;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Tan;
            sidebar.Controls.Add(dashboardBtn);
            sidebar.Controls.Add(booksBtn);
            sidebar.Controls.Add(finesBtn);
            sidebar.Controls.Add(loansBtn);
            sidebar.Controls.Add(membersBtn);
            sidebar.Controls.Add(reservationBtn);
            sidebar.Controls.Add(notificationsBtn);
            sidebar.Controls.Add(librariansButton);
            sidebar.Controls.Add(logoutBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 44);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(250, 557);
            sidebar.TabIndex = 8;
            // 
            // dashboardBtn
            // 
            dashboardBtn.BackColor = Color.Tan;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dashboardBtn.Image = Properties.Resources.dashboard_85_32;
            dashboardBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.Location = new Point(3, 3);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(246, 49);
            dashboardBtn.TabIndex = 9;
            dashboardBtn.Text = "          Dashboard";
            dashboardBtn.TextAlign = ContentAlignment.MiddleLeft;
            dashboardBtn.UseVisualStyleBackColor = false;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // booksBtn
            // 
            booksBtn.BackColor = Color.Tan;
            booksBtn.FlatStyle = FlatStyle.Flat;
            booksBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            booksBtn.Image = Properties.Resources.books_41_32;
            booksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            booksBtn.Location = new Point(3, 58);
            booksBtn.Name = "booksBtn";
            booksBtn.Size = new Size(246, 49);
            booksBtn.TabIndex = 11;
            booksBtn.Text = "          Books";
            booksBtn.TextAlign = ContentAlignment.MiddleLeft;
            booksBtn.UseVisualStyleBackColor = false;
            booksBtn.Click += booksBtn_Click;
            // 
            // finesBtn
            // 
            finesBtn.BackColor = Color.Tan;
            finesBtn.FlatStyle = FlatStyle.Flat;
            finesBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            finesBtn.Image = Properties.Resources.court_8_32;
            finesBtn.ImageAlign = ContentAlignment.MiddleLeft;
            finesBtn.Location = new Point(3, 113);
            finesBtn.Name = "finesBtn";
            finesBtn.Size = new Size(246, 49);
            finesBtn.TabIndex = 12;
            finesBtn.Text = "          Fines";
            finesBtn.TextAlign = ContentAlignment.MiddleLeft;
            finesBtn.UseVisualStyleBackColor = false;
            finesBtn.Click += finesBtn_Click;
            // 
            // loansBtn
            // 
            loansBtn.BackColor = Color.Tan;
            loansBtn.FlatStyle = FlatStyle.Flat;
            loansBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loansBtn.Image = Properties.Resources.borrow_money_3_32;
            loansBtn.ImageAlign = ContentAlignment.MiddleLeft;
            loansBtn.Location = new Point(3, 168);
            loansBtn.Name = "loansBtn";
            loansBtn.Size = new Size(246, 49);
            loansBtn.TabIndex = 13;
            loansBtn.Text = "          Loans";
            loansBtn.TextAlign = ContentAlignment.MiddleLeft;
            loansBtn.UseVisualStyleBackColor = false;
            loansBtn.Click += loansBtn_Click;
            // 
            // membersBtn
            // 
            membersBtn.BackColor = Color.Tan;
            membersBtn.FlatStyle = FlatStyle.Flat;
            membersBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            membersBtn.Image = Properties.Resources.people_71_32;
            membersBtn.ImageAlign = ContentAlignment.MiddleLeft;
            membersBtn.Location = new Point(3, 223);
            membersBtn.Name = "membersBtn";
            membersBtn.Size = new Size(246, 49);
            membersBtn.TabIndex = 14;
            membersBtn.Text = "          Members";
            membersBtn.TextAlign = ContentAlignment.MiddleLeft;
            membersBtn.UseVisualStyleBackColor = false;
            membersBtn.Click += membersBtn_Click;
            // 
            // reservationBtn
            // 
            reservationBtn.BackColor = Color.Tan;
            reservationBtn.FlatStyle = FlatStyle.Flat;
            reservationBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            reservationBtn.Image = Properties.Resources.calendar_197_32;
            reservationBtn.ImageAlign = ContentAlignment.MiddleLeft;
            reservationBtn.Location = new Point(3, 278);
            reservationBtn.Name = "reservationBtn";
            reservationBtn.Size = new Size(246, 49);
            reservationBtn.TabIndex = 11;
            reservationBtn.Text = "          Reservations";
            reservationBtn.TextAlign = ContentAlignment.MiddleLeft;
            reservationBtn.UseVisualStyleBackColor = false;
            // 
            // notificationsBtn
            // 
            notificationsBtn.BackColor = Color.Tan;
            notificationsBtn.FlatStyle = FlatStyle.Flat;
            notificationsBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            notificationsBtn.Image = Properties.Resources.notification_10_32;
            notificationsBtn.ImageAlign = ContentAlignment.MiddleLeft;
            notificationsBtn.Location = new Point(3, 333);
            notificationsBtn.Name = "notificationsBtn";
            notificationsBtn.Size = new Size(246, 49);
            notificationsBtn.TabIndex = 12;
            notificationsBtn.Text = "          Notifications";
            notificationsBtn.TextAlign = ContentAlignment.MiddleLeft;
            notificationsBtn.UseVisualStyleBackColor = false;
            // 
            // librariansButton
            // 
            librariansButton.BackColor = Color.Tan;
            librariansButton.FlatStyle = FlatStyle.Flat;
            librariansButton.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            librariansButton.Image = Properties.Resources.glasses_60_32;
            librariansButton.ImageAlign = ContentAlignment.MiddleLeft;
            librariansButton.Location = new Point(3, 388);
            librariansButton.Name = "librariansButton";
            librariansButton.Size = new Size(246, 49);
            librariansButton.TabIndex = 13;
            librariansButton.Text = "          Librarians";
            librariansButton.TextAlign = ContentAlignment.MiddleLeft;
            librariansButton.UseVisualStyleBackColor = false;
            librariansButton.Click += librariansButton_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Tan;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutBtn.Image = Properties.Resources.logout_36_32;
            logoutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            logoutBtn.Location = new Point(3, 443);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(246, 49);
            logoutBtn.TabIndex = 11;
            logoutBtn.Text = "          Logout";
            logoutBtn.TextAlign = ContentAlignment.MiddleLeft;
            logoutBtn.UseVisualStyleBackColor = false;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // dailyTimer
            // 
            dailyTimer.Interval = 30000;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 601);
            Controls.Add(mainPanel);
            Controls.Add(sidebar);
            Controls.Add(panel2);
            Name = "FormMain";
            Text = "The Library";
            Load += FormMain_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label LibrarianLabel;
        private FlowLayoutPanel sidebar;
        private Button dashboardBtn;
        private Button booksBtn;
        private Button finesBtn;
        private Button loansBtn;
        private Button membersBtn;
        private Button reservationBtn;
        private Button notificationsBtn;
        private Button librariansButton;
        private Button logoutBtn;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button hamBtn;
        private Panel mainPanel;
        private System.Windows.Forms.Timer dailyTimer;
    }
}