using System;
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
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnInteractWithAnimal_Click(object sender, EventArgs e)
        {
            ActionForm actionForm = new ActionForm();
            actionForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}