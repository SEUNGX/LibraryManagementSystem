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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        // Set form opacity when it loads
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
        }

        // Add rounded, transparent panel
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Set a semi-transparent background for the panel (RGBA with alpha = 120 for transparency)
            var color = Color.FromArgb(120, 255, 255, 255); // RGBA with transparency (alpha = 120)
            using (SolidBrush brush = new SolidBrush(color))
            {
                e.Graphics.FillRectangle(brush, panel1.ClientRectangle);
            }

            // Draw a rounded border
            var borderColor = Color.Gray; // Border color
            var borderWidth = 3; // Border width
            var borderRadius = 20; // Border radius for rounded corners

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                // Create a rounded rectangle path
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawArc(pen, new Rectangle(0, 0, borderRadius, borderRadius), 180, 90); // Top left
                e.Graphics.DrawArc(pen, new Rectangle(panel1.Width - borderRadius, 0, borderRadius, borderRadius), 270, 90); // Top right
                e.Graphics.DrawArc(pen, new Rectangle(0, panel1.Height - borderRadius, borderRadius, borderRadius), 90, 90); // Bottom left
                e.Graphics.DrawArc(pen, new Rectangle(panel1.Width - borderRadius, panel1.Height - borderRadius, borderRadius, borderRadius), 0, 90); // Bottom right
                e.Graphics.DrawLine(pen, borderRadius, 0, panel1.Width - borderRadius, 0); // Top side
                e.Graphics.DrawLine(pen, 0, borderRadius, 0, panel1.Height - borderRadius); // Left side
                e.Graphics.DrawLine(pen, 0, panel1.Height - borderRadius, panel1.Width, panel1.Height - borderRadius); // Bottom side
                e.Graphics.DrawLine(pen, panel1.Width - borderRadius, 0, panel1.Width - borderRadius, panel1.Height); // Right side
            }
        }

 




        private void btnRegister_Click(object sender, EventArgs e)
        {

            //FormMain fr = new FormMain();
            //fr.Show();
            //this.Hide();

            this.DialogResult = DialogResult.OK; // Signal that login was successful
        }
    }
}
