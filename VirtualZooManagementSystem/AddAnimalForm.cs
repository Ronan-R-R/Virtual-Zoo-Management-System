using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class AddAnimalForm : Form
    {
        public Animal NewAnimal { get; private set; }

        private ComboBox comboBoxFoodType;
        private ComboBox comboBoxHabitatType;
        private AnimalType animalType; // Declare animalType variable

        public AddAnimalForm(AnimalType animalType) // Add constructor to pass animalType
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.animalType = animalType; // Assign animalType

            // Initialize combo boxes for food type and habitat type
            comboBoxFoodType = new ComboBox();
            comboBoxFoodType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFoodType.Items.AddRange(Enum.GetNames(typeof(FoodType)));
            comboBoxFoodType.Location = new Point(102, 206);
            comboBoxFoodType.SelectedIndex = 0;
            this.Controls.Add(comboBoxFoodType);

            comboBoxHabitatType = new ComboBox();
            comboBoxHabitatType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHabitatType.Items.AddRange(Enum.GetNames(typeof(HabitatType)));
            comboBoxHabitatType.Location = new Point(102, 236);
            comboBoxHabitatType.SelectedIndex = 0;
            this.Controls.Add(comboBoxHabitatType);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            int age = (int)numericUpDownAge.Value;
            string sound = textBoxSound.Text.Trim();
            string movement = textBoxMovement.Text.Trim();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sound) && !string.IsNullOrEmpty(movement))
            {
                // Get selected food type and habitat type
                FoodType foodType = (FoodType)comboBoxFoodType.SelectedIndex;
                HabitatType habitatType = (HabitatType)comboBoxHabitatType.SelectedIndex;

                // Create a new animal based on the selected type
                switch (animalType) // Use the animalType obtained from the constructor
                {
                    case AnimalType.Mammal:
                        NewAnimal = new Mammal(name, age, sound, movement, foodType, habitatType);
                        break;
                    case AnimalType.Bird:
                        NewAnimal = new Bird(name, age, sound, movement, foodType, habitatType);
                        break;
                    case AnimalType.Reptile:
                        NewAnimal = new Reptile(name, age, sound, movement, foodType, habitatType);
                        break;
                    case AnimalType.Fish:
                        NewAnimal = new Fish(name, age, sound, movement, foodType, habitatType);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown animal type.");
                }

                // Set dialog result to OK if creation is successful
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
