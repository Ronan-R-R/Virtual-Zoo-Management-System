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
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            // Pass the AnimalType value when creating an instance of AddAnimalForm
            AddAnimalForm addAnimalForm = new AddAnimalForm(AnimalType.Mammal);
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
        }

        private void listBoxZoo_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAnimalDetails();
        }

        private void UpdateListBox()
        {
            listBoxZoo.DataSource = null;
            listBoxZoo.DisplayMember = "Name";
            listBoxZoo.DataSource = zoo;
        }

        private void DisplayAnimalDetails(Animal animal)
        {
            labelName.Text = $"Name: {animal.Name}";
            labelAnimalType.Text = $"Type: {animal.AnimalType}";
            labelAge.Text = $"Age: {animal.Age}";
            labelSound.Text = $"Sound: {animal.Sound}";
            labelMovement.Text = $"Movement: {animal.Movement}";

            labelName.Visible = true;
            labelAnimalType.Visible = true;
            labelAge.Visible = true;
            labelSound.Visible = true;
            labelMovement.Visible = true;
        }

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
