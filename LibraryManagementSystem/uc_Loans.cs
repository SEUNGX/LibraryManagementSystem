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
    public partial class uc_Loans : UserControl
    {

        FormMain mainForm;

        public uc_Loans(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addLoanBtn_Click(object sender, EventArgs e)
        {
            uc_AddLoan addLoanControl = new uc_AddLoan(mainForm);
            mainForm.SwitchUserControl(addLoanControl);
        }

    }
}
