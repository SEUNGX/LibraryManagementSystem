﻿using System;
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
    public partial class uc_dashboard : UserControl
    {
        public uc_dashboard()
        {
            InitializeComponent();
        }

        private void uc_dashboard_Load(object sender, EventArgs e)
        {
            DatabaseHelper db = new DatabaseHelper();
            int bookCount = db.GetTotalBooks();
            totalBooksNumLabel.Text = bookCount.ToString(); // Show it in a label


        }




    }
}
