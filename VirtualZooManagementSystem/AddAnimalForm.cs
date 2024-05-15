using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class AddAnimalForm : Form
    {
        public Animal NewAnimal { get; private set; }

        private ComboBox comboBoxFoodType;
        private ComboBox comboBoxHabitatType;
        private ComboBox comboBoxAnimalType; // Added comboBoxAnimalType
        private TextBox textBoxSpecies; // Added textBoxSpecies

        public AddAnimalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Prevent resizing

            // Initialize combo boxes for food type, habitat type, and animal type
            comboBoxFoodType = new ComboBox();
            comboBoxFoodType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFoodType.Items.AddRange(Enum.GetNames(typeof(FoodType)));
            comboBoxFoodType.Location = new System.Drawing.Point(225, 34); // Adjusted location
            comboBoxFoodType.Size = new System.Drawing.Size(150, 21); // Adjusted size
            comboBoxFoodType.SelectedIndex = 0;
            this.Controls.Add(comboBoxFoodType);

            comboBoxHabitatType = new ComboBox();
            comboBoxHabitatType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHabitatType.Items.AddRange(Enum.GetNames(typeof(HabitatType)));
            comboBoxHabitatType.Location = new System.Drawing.Point(225, 80); // Adjusted location
            comboBoxHabitatType.Size = new System.Drawing.Size(150, 21); // Adjusted size
            comboBoxHabitatType.SelectedIndex = 0;
            this.Controls.Add(comboBoxHabitatType);

            comboBoxAnimalType = new ComboBox(); // Initialize comboBoxAnimalType
            comboBoxAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnimalType.Items.AddRange(Enum.GetNames(typeof(AnimalType)));
            comboBoxAnimalType.Location = new System.Drawing.Point(225, 126); // Adjusted location
            comboBoxAnimalType.Size = new System.Drawing.Size(150, 21); // Adjusted size
            comboBoxAnimalType.SelectedIndex = 0;
            this.Controls.Add(comboBoxAnimalType);

            // Initialize textBoxSpecies
            textBoxSpecies = new TextBox();
            textBoxSpecies.Location = new System.Drawing.Point(225, 172); // Adjusted location
            textBoxSpecies.Size = new System.Drawing.Size(150, 20); // Adjusted size
            this.Controls.Add(textBoxSpecies);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            int age = (int)numericUpDownAge.Value;
            string sound = textBoxSound.Text.Trim();
            string movement = textBoxMovement.Text.Trim();
            string species = textBoxSpecies.Text.Trim(); // Get species from textBoxSpecies

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sound) && !string.IsNullOrEmpty(movement))
            {
                FoodType foodType = (FoodType)comboBoxFoodType.SelectedIndex;
                HabitatType habitatType = (HabitatType)comboBoxHabitatType.SelectedIndex;
                AnimalType animalType = (AnimalType)comboBoxAnimalType.SelectedIndex; // Get selected animal type

                switch (animalType)
                {
                    case AnimalType.Mammal:
                        NewAnimal = new Mammal(name, age, sound, movement, foodType, habitatType, species); // Pass species to constructor
                        break;
                    case AnimalType.Bird:
                        NewAnimal = new Bird(name, age, sound, movement, foodType, habitatType, species); // Pass species to constructor
                        break;
                    case AnimalType.Reptile:
                        NewAnimal = new Reptile(name, age, sound, movement, foodType, habitatType, species); // Pass species to constructor
                        break;
                    case AnimalType.Fish:
                        NewAnimal = new Fish(name, age, sound, movement, foodType, habitatType, species); // Pass species to constructor
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown animal type.");
                }

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}