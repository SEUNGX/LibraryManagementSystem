using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class uc_userLibrarians : UserControl
    {
        private FormMain mainForm;

        public uc_userLibrarians(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addLibrarianBtn_Click(object sender, EventArgs e)
        {
            // Create an instance of uc_Librarians
            uc_Librarians librariansControl = new uc_Librarians(mainForm);

            // Switch to the uc_Librarians user control
            mainForm.SwitchUserControl(librariansControl);
        }
    }
}
