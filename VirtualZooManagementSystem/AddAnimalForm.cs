using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    // Partial class for the form to add a new animal
    public partial class AddAnimalForm : Form
    {
        // Property to get the newly created animal
        public Animal NewAnimal { get; private set; }

        // Constructor for the AddAnimalForm
        public AddAnimalForm()
        {
            // Initialize the AddAnimalForm components
            InitializeComponent();
            // Center the AddAnimalForm on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Event handler for the "Add" button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve values from the form controls
            string name = textBoxName.Text.Trim();
            int age = (int)numericUpDownAge.Value;
            string sound = textBoxSound.Text.Trim();
            string movement = textBoxMovement.Text.Trim();
            string animalType = textBoxAnimalType.Text.Trim();

            // Check if all fields are filled
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sound) && !string.IsNullOrEmpty(movement) && !string.IsNullOrEmpty(animalType))
            {
                // Create a new Animal object with the provided values
                NewAnimal = new Animal(name, age, sound, movement, animalType);
                // Set the dialog result to OK to indicate successful completion
                DialogResult = DialogResult.OK;
            }
            else
            {
                // Display an error message if any field is empty
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}