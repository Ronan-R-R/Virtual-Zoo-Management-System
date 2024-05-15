using System;
using System.Windows.Forms;

namespace VirtualZooManagementSystem
{
    public partial class AddAnimalForm : Form
    {
        public Animal NewAnimal { get; private set; }

        private ComboBox comboBoxFoodType;
        private ComboBox comboBoxHabitatType;
        private ComboBox comboBoxAnimalType;
        private TextBox textBoxSpecies;

        public AddAnimalForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 

            comboBoxFoodType = new ComboBox();
            comboBoxFoodType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFoodType.Items.AddRange(Enum.GetNames(typeof(FoodType)));
            comboBoxFoodType.Location = new System.Drawing.Point(225, 34); 
            comboBoxFoodType.Size = new System.Drawing.Size(150, 21); 
            comboBoxFoodType.SelectedIndex = 0;
            this.Controls.Add(comboBoxFoodType);

            comboBoxHabitatType = new ComboBox();
            comboBoxHabitatType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHabitatType.Items.AddRange(Enum.GetNames(typeof(HabitatType)));
            comboBoxHabitatType.Location = new System.Drawing.Point(225, 80); 
            comboBoxHabitatType.Size = new System.Drawing.Size(150, 21); 
            comboBoxHabitatType.SelectedIndex = 0;
            this.Controls.Add(comboBoxHabitatType);

            comboBoxAnimalType = new ComboBox(); 
            comboBoxAnimalType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAnimalType.Items.AddRange(Enum.GetNames(typeof(AnimalType)));
            comboBoxAnimalType.Location = new System.Drawing.Point(225, 126); 
            comboBoxAnimalType.Size = new System.Drawing.Size(150, 21); 
            comboBoxAnimalType.SelectedIndex = 0;
            this.Controls.Add(comboBoxAnimalType);

            textBoxSpecies = new TextBox();
            textBoxSpecies.Location = new System.Drawing.Point(225, 172); 
            textBoxSpecies.Size = new System.Drawing.Size(150, 20); 
            this.Controls.Add(textBoxSpecies);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            int age = (int)numericUpDownAge.Value;
            string sound = textBoxSound.Text.Trim();
            string movement = textBoxMovement.Text.Trim();
            string species = textBoxSpecies.Text.Trim(); 

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(sound) && !string.IsNullOrEmpty(movement))
            {
                FoodType foodType = (FoodType)comboBoxFoodType.SelectedIndex;
                HabitatType habitatType = (HabitatType)comboBoxHabitatType.SelectedIndex;
                AnimalType animalType = (AnimalType)comboBoxAnimalType.SelectedIndex; 

                switch (animalType)
                {
                    case AnimalType.Mammal:
                        NewAnimal = new Mammal(name, age, sound, movement, foodType, habitatType, species); 
                        break;
                    case AnimalType.Bird:
                        NewAnimal = new Bird(name, age, sound, movement, foodType, habitatType, species); 
                        break;
                    case AnimalType.Reptile:
                        NewAnimal = new Reptile(name, age, sound, movement, foodType, habitatType, species); 
                        break;
                    case AnimalType.Fish:
                        NewAnimal = new Fish(name, age, sound, movement, foodType, habitatType, species); 
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unknown animal type.");
                }

                // Add the new animal to the shared list in Program.cs
                Program.Zoo.Add(NewAnimal);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
