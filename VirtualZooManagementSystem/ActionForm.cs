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
        // got too annoyed ;-;
        /*private void btnListen_Click(object sender, EventArgs e)
        {
            AnimalMenuForm animalMenuForm = new AnimalMenuForm(zoo);
            animalMenuForm.StartPosition = FormStartPosition.CenterScreen;
            animalMenuForm.ShowDialog();
        }*/
        private DateTime lastFeedTime = DateTime.MinValue;
        private void btnFeed_Click(object sender, EventArgs e)
        {
            TimeSpan timeSinceLastFeed = DateTime.Now - lastFeedTime;
            if (timeSinceLastFeed.TotalHours < 12)
            {
                MessageBox.Show("Animals already have been fed", "Feed Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Animals are now fed", "Feed Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lastFeedTime = DateTime.Now; // Update the last feed time
            }
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.StartPosition = FormStartPosition.CenterScreen;
            mainMenuForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}