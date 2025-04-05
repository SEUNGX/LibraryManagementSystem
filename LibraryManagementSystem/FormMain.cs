namespace LibraryManagementSystem
{
    public partial class FormMain : Form
    {

        // Create a new instance of the uc_dashboard UserControl
        uc_dashboard ucDashboard = new uc_dashboard();

        public FormMain()
        {
            InitializeComponent();
        }



        //bool sidebarExpand = true;

        //private void sidebarTransiton_Tick(object sender, EventArgs e)
        //{
        //    if (sidebarExpand)
        //    {
        //        sidebar.Width = 10;
        //        if  (sidebar.Width <= 47)
        //        {
        //            sidebarExpand = false;
        //            sidebarTransition.Stop();
        //        }
        //    } else
        //    {
        //        sidebar.Width += 10;
        //        if (sidebar.Width >= 250)
        //        {
        //            sidebarExpand = true;
        //            sidebarTransition.Stop();
        //        }
        //    }
        //}

        //private void hamBtn_Click(object sender, EventArgs e)
        //{
        //    sidebarTransition.Start();
        //}

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



        private void FormMain_Load(object sender, EventArgs e)
        {


            // Clear existing controls in the mainPanel to ensure it's empty before adding the new control
            mainPanel.Controls.Clear();

            // Add the new UserControl to the mainPanel
            mainPanel.Controls.Add(ucDashboard);

            // Set the UserControl to fill the entire mainPanel
            ucDashboard.Dock = DockStyle.Fill;
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

    }
}
