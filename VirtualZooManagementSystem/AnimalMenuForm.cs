using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class AnimalMenuForm : Form
    {
        private List<Animal> zoo;

        public AnimalMenuForm(List<Animal> zoo)
        {
            InitializeComponent();
            this.zoo = zoo;
            PopulateAnimalList();
        }

        private void PopulateAnimalList()
        {
            listBoxAnimals.DisplayMember = "Name";
            listBoxAnimals.DataSource = zoo;
        }

        private void listBoxAnimals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAnimals.SelectedItem != null)
            {
                Animal selectedAnimal = (Animal)listBoxAnimals.SelectedItem;
                MessageBox.Show(selectedAnimal.Sound, selectedAnimal.Name);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.ToLower();
            var searchResults = zoo.Where(animal => animal.Name.ToLower().Contains(searchText)).ToList();
            listBoxAnimals.DataSource = null;
            listBoxAnimals.DataSource = searchResults;
        }
    }
}