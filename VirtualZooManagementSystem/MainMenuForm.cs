using System;
using System.Collections.Generic; // Add this line to import the namespace
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
            CenterToScreen(); // Center the form on the screen
            FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing
            MaximizeBox = false; // Disable maximize button
            MinimizeBox = false; // Disable minimize button
        }

        private void btnManageAnimals_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnInteractWithAnimal_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            List<Animal> dummyZoo = new List<Animal>(); // Create a dummy list of animals for demonstration
            ActionForm actionForm = new ActionForm(dummyZoo);
            actionForm.ShowDialog();
            this.Close(); // Close the current form after ActionForm is closed
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}