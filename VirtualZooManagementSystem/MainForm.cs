using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    // Partial class for the main form of the Virtual Zoo Management System
    public partial class MainForm : Form
    {
        // List to store the animals in the zoo
        private List<Animal> zoo;

        // Constructor for the MainForm
        public MainForm()
        {
            // Initialize the MainForm components
            InitializeComponent();
            // Initialize the zoo list
            zoo = new List<Animal>();
            // Center the MainForm on the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Event handler for the "Add Animal" button click
        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Instantiate the form to add a new animal
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            // Show the form modally
            DialogResult result = addAnimalForm.ShowDialog();

            // If the user clicks OK on the dialog, add the new animal to the zoo and update the list box
            if (result == DialogResult.OK)
            {
                zoo.Add(addAnimalForm.NewAnimal);
                UpdateListBox();
            }
        }

        // Event handler for the "Search" button click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search text from the search box and convert it to lowercase
            string searchText = textBoxSearch.Text.ToLower();
            // Filter the zoo list based on the search text
            var searchResults = zoo.Where(animal =>
                animal.Name.ToLower().Contains(searchText) ||
                animal.AnimalType.ToLower().Contains(searchText)).ToList();

            // Set the data source of the list box to the search results
            listBoxZoo.DataSource = null;
            listBoxZoo.DisplayMember = "Name";
            listBoxZoo.DataSource = searchResults;
        }

        // Event handler for the "Reset" button click
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear the search box and update the list box with all animals in the zoo
            textBoxSearch.Clear();
            UpdateListBox();
        }

        // Event handler for the selection change in the list box
        private void listBoxZoo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If an item is selected in the list box, display its details; otherwise, clear the details
            if (listBoxZoo.SelectedItem != null)
            {
                Animal selectedAnimal = (Animal)listBoxZoo.SelectedItem;
                DisplayAnimalDetails(selectedAnimal);
            }
            else
            {
                ClearAnimalDetails();
            }
        }

        // Event handler for the "Clear" button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the displayed animal details
            ClearAnimalDetails();
        }

        // Method to update the list box with all animals in the zoo
        private void UpdateListBox()
        {
            listBoxZoo.DataSource = null;
            listBoxZoo.DisplayMember = "Name";
            listBoxZoo.DataSource = zoo;
        }

        // Method to display the details of the selected animal
        private void DisplayAnimalDetails(Animal animal)
        {
            labelName.Text = $"Name: {animal.Name}";
            labelAnimalType.Text = $"Type: {animal.AnimalType}";
            labelAge.Text = $"Age: {animal.DisplayAge}";
            labelSound.Text = $"Sound: {animal.Sound}";
            labelMovement.Text = $"Movement: {animal.Movement}";

            labelName.Visible = true;
            labelAnimalType.Visible = true;
            labelAge.Visible = true;
            labelSound.Visible = true;
            labelMovement.Visible = true;
        }

        // Method to clear the displayed animal details
        private void ClearAnimalDetails()
        {
            labelName.Visible = false;
            labelAnimalType.Visible = false;
            labelAge.Visible = false;
            labelSound.Visible = false;
            labelMovement.Visible = false;
        }
    }
}
