using Microsoft.Data.SqlClient;
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
    public partial class uc_AddMember : UserControl
    {
        FormMain mainForm;

        public uc_AddMember(FormMain form)
        {
            InitializeComponent();
            mainForm = form;
        }

        private void saveMemberBtn_Click(object sender, EventArgs e)
        {
            string firstName = memberFNtb.Text.Trim();
            string lastName = memberLNtb.Text.Trim();
            string email = memberEmailtb.Text.Trim();
            string phone = memberPhonetb.Text.Trim();
            string address = memberAddresstb.Text.Trim();
            DateTime birthdate = memberBirthdatePicker.Value.Date;
            long registeredBy = Session.LoggedInUserID;

            // Validations
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(address))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!phone.All(char.IsDigit) || phone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits and contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (birthdate < new DateTime(1900, 1, 1) || birthdate > DateTime.Today)
            {
                MessageBox.Show("Please select a birthdate between 1900 and today.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert member
            DatabaseHelper db = new DatabaseHelper();
            db.InsertMember(firstName, lastName, email, phone, address, birthdate, registeredBy);

            MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            uc_Members membersControl = new uc_Members(mainForm);
            mainForm.SwitchUserControl(membersControl);
        }


        private void discardMemberBtn_Click(object sender, EventArgs e)
        {
            uc_Members membersControl = new uc_Members(mainForm);
            mainForm.SwitchUserControl(membersControl);
        }

       
    }
}
