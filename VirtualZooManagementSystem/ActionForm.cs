using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class ActionForm : Form
    {
        private List<Animal> zoo;

        public ActionForm(List<Animal> zoo)
        {
            InitializeComponent();
            CenterToScreen(); // Center the form on the screen
            FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing
            MaximizeBox = false; // Disable maximize button
            MinimizeBox = false; // Disable minimize button
            this.zoo = zoo;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            AnimalMenuForm animalMenuForm = new AnimalMenuForm(zoo);
            animalMenuForm.StartPosition = FormStartPosition.CenterScreen;
            animalMenuForm.ShowDialog();
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