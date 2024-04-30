namespace VirtualZooManagementSystem
{
    // Class representing an animal in the virtual zoo
    public class Animal
    {
        private int age; // Private field to store the age of the animal

        // Public property to get the name of the animal and allow setting within the class hierarchy
        public string Name { get; protected set; }

        // Public property to display the age of the animal, with special handling for ages less than 1
        public string DisplayAge => age == 0 ? "< 1" : age.ToString();

        // Public property to get the age of the animal and allow setting within the class hierarchy
        public int Age
        {
            get { return age; }
            protected set { age = value; }
        }

        // Public property to get the sound the animal makes
        public string Sound { get; protected set; }

        // Public property to get the movement pattern of the animal
        public string Movement { get; protected set; }

        // Public property to get the type of the animal
        public string AnimalType { get; protected set; }

        // Constructor to initialize an instance of the Animal class with provided parameters
        public Animal(string name, int age, string sound, string movement, string animalType)
        {
            // Initialize the properties of the animal with the provided values
            Name = name;
            Age = age;
            Sound = sound;
            Movement = movement;
            AnimalType = animalType;
        }
    }
}