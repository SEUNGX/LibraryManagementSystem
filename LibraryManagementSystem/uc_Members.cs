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
    public partial class uc_Members : UserControl
    {
        FormMain mainForm;

        public uc_Members(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            uc_AddMember addMemberControl = new uc_AddMember(mainForm);
            mainForm.SwitchUserControl(addMemberControl);
        }
    }
}
