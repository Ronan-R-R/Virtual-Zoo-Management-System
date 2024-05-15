using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class ActionForm : Form
    {
        public ActionForm()
        {
            InitializeComponent();
            CenterToScreen(); // Center the form on the screen
            FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing
            MaximizeBox = false; // Disable maximize button
            MinimizeBox = false; // Disable minimize button
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            // Implement listening action
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            // Implement feeding action
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}