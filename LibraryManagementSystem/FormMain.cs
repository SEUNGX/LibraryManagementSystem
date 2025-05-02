namespace LibraryManagementSystem
{
    public partial class FormMain : Form
    {

        // Create a new instance of the uc_dashboard UserControl
        uc_dashboard ucDashboard = new uc_dashboard();
        //uc_AddBook uc_AddBook = new uc_AddBook();
        //ucBooks ucBooks = new ucBooks();



        public FormMain()
        {
            InitializeComponent();
        }




        bool sidebarExpand = true; // Initially expanded

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            int step = 5;
            // Collapse the sidebar
            if (sidebarExpand)
            {
                sidebar.Width -= step; // Gradually decrease width
                if (sidebar.Width <= 47) // Stop at the collapsed width
                {
                    sidebarExpand = false; // Set to collapsed state
                    sidebarTransition.Stop();
                }
            }
            // Expand the sidebar
            else
            {
                sidebar.Width += step; // Gradually increase width
                if (sidebar.Width >= 250) // Stop at the expanded width
                {
                    sidebarExpand = true; // Set to expanded state
                    sidebarTransition.Stop();
                }
            }
        }

        private void hamBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start(); // Start animation
        }

        private System.Windows.Forms.Timer fineCheckTimer;

        private void FineCheckTimer_Tick(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            db.GenerateDailyFines();
            db.UpdateDailyFines();
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            db.MarkExpiredReservations();
            fineCheckTimer = new System.Windows.Forms.Timer();
            fineCheckTimer.Interval = 30000; // 30 seconds
            fineCheckTimer.Tick += FineCheckTimer_Tick;
            fineCheckTimer.Start();

            // Clear existing controls in the mainPanel to ensure it's empty before adding the new control
            mainPanel.Controls.Clear();

            // Add the new UserControl to the mainPanel
            mainPanel.Controls.Add(ucDashboard);

            // Set the UserControl to fill the entire mainPanel
            ucDashboard.Dock = DockStyle.Fill;
            //test
        }

        public void SwitchUserControl(UserControl newControl)
        {
            mainPanel.Controls.Clear();
            newControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(newControl);
        }



        private void dashboardBtn_Click(object sender, EventArgs e)
        {


            // Clear existing controls in the mainPanel to ensure it's empty before adding the new control
            mainPanel.Controls.Clear();

            // Add the new UserControl to the mainPanel
            mainPanel.Controls.Add(ucDashboard);

            // Set the UserControl to fill the entire mainPanel
            ucDashboard.Dock = DockStyle.Fill;
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {

            ucBooks booksControl = new ucBooks(this);
            SwitchUserControl(booksControl);

        }

        private void librariansButton_Click(object sender, EventArgs e)
        {
            // Create an instance of uc_Librarians
            uc_userLibrarians userlibrariansControl = new uc_userLibrarians(this);

            // Switch to the uc_Librarians user control
            SwitchUserControl(userlibrariansControl);
        }

        private void membersBtn_Click(object sender, EventArgs e)
        {
            uc_Members membersControl = new uc_Members(this); // pass 'this' if needed for context
            SwitchUserControl(membersControl);
        }

        private void loansBtn_Click(object sender, EventArgs e)
        {
            uc_Loans loansControl = new uc_Loans(this);
            SwitchUserControl(loansControl);
        }

        private void finesBtn_Click(object sender, EventArgs e)
        {
            uc_Fines finesControl = new uc_Fines(this);
            SwitchUserControl(finesControl);
        }

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            uc_Reservations reservationsControl = new uc_Reservations(this);
            SwitchUserControl(reservationsControl);
        }
    }
}
