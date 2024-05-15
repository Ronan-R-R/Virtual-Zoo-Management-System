using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace VirtualZooManagementSystem
{
    public partial class MainMenuForm : Form
    {
        private List<Animal> dummyZoo; // Declare dummyZoo as a field in MainMenuForm

        public MainMenuForm()
        {
            InitializeComponent();
            dummyZoo = new List<Animal>(); // Initialize dummyZoo
            
            this.StartPosition = FormStartPosition.CenterScreen;
            // Set form border style to fixed and remove maximize box
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btnManageAnimals_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnInteract_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm(dummyZoo);
            actionForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}