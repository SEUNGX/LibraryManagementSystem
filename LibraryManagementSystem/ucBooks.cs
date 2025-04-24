using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ucBooks : UserControl
    {

        FormMain mainForm;

        public ucBooks(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            uc_AddBook addBookControl = new uc_AddBook(mainForm);
            mainForm.SwitchUserControl(addBookControl);
        }

        private void addCategoryBtn_Click(object sender, EventArgs e)
        {
            uc_Category addCategoryControl = new uc_Category(mainForm);
            mainForm.SwitchUserControl(addCategoryControl);
        }

        private void addAuthorBtn_Click(object sender, EventArgs e)
        {
            uc_AddAuthor addAuthorControl = new uc_AddAuthor(mainForm);
            mainForm.SwitchUserControl(addAuthorControl);
        }
    }
}
