using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class MainForm : Form
    {
        private List<Animal> zoo;

        public MainForm()
        {
            InitializeComponent();
            zoo = new List<Animal>();
            this.StartPosition = FormStartPosition.CenterScreen;
            // Initialize labels to be always visible
            SetLabelVisibility(true);
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            AddAnimalForm addAnimalForm = new AddAnimalForm();
            DialogResult result = addAnimalForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                zoo.Add(addAnimalForm.NewAnimal);
                UpdateListBox();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            var searchResults = zoo.Where(animal =>
                animal.Name.ToLower().Contains(searchText) ||
                animal.AnimalType.ToString().ToLower().Contains(searchText)).ToList();

            listBoxZoo.DataSource = null;
            listBoxZoo.DisplayMember = "Name";
            listBoxZoo.DataSource = searchResults;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            UpdateListBox();
            // Clear the details and hide the labels
            ClearAnimalDetails();
            SetLabelVisibility(false);
        }

        private void listBoxZoo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxZoo.SelectedItem != null)
            {
                Animal selectedAnimal = (Animal)listBoxZoo.SelectedItem;
                DisplayAnimalDetails(selectedAnimal);
                // Show the labels and details
                SetLabelVisibility(true);
            }
            else
            {
                // If no item is selected, clear the details and hide the labels
                ClearAnimalDetails();
                SetLabelVisibility(false);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the details only and hide the labels
            ClearAnimalDetails();
            SetLabelVisibility(false);
        }

        private void UpdateListBox()
        {
            listBoxZoo.DataSource = null;
            listBoxZoo.DisplayMember = "Name";
            listBoxZoo.DataSource = zoo;
        }

        private void DisplayAnimalDetails(Animal animal)
        {
            // Clear previous details
            ClearAnimalDetails();

            // Column 1
            labelName.Text = $"Name: {animal.Name}";
            labelAnimalType.Text = $"Animal Type: {animal.AnimalType}";
            labelAge.Text = $"Age: {animal.Age}";
            labelSound.Text = $"Sound: {animal.Sound}";

            // Column 2
            labelMovement.Text = $"Movement: {animal.Movement}";
            labelSpecies.Text = $"Species: {animal.Species}";
            labelFoodType.Text = $"Food Type: {animal.FoodType}";
            labelHabitatType.Text = $"Habitat Type: {animal.HabitatType}";
        }

        private void ClearAnimalDetails()
        {
            labelName.Text = "";
            labelAnimalType.Text = "";
            labelAge.Text = "";
            labelSound.Text = "";
            labelMovement.Text = "";
            labelSpecies.Text = "";
            labelFoodType.Text = "";
            labelHabitatType.Text = "";
        }

        private void SetLabelVisibility(bool visible)
        {
            labelName.Visible = visible;
            labelAnimalType.Visible = visible;
            labelAge.Visible = visible;
            labelSound.Visible = visible;
            labelMovement.Visible = visible;
            labelSpecies.Visible = visible;
            labelFoodType.Visible = visible;
            labelHabitatType.Visible = visible;
        }
    }
}
