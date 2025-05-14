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
    public partial class DueDatePickerForm : Form
    {
        public DateTime SelectedDueDate { get; private set; }

        public DueDatePickerForm()
        {
            InitializeComponent();
            dueDatePicker.Value = DateTime.Now.AddDays(7);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            SelectedDueDate = dueDatePicker.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
