using System;

namespace VirtualZooManagementSystem
{
    // Enum to classify different types of animals
    public enum AnimalType
    {
        Mammal,
        Bird,
        Reptile,
        Fish
    }

    // Enum to classify different types of food
    public enum FoodType
    {
        Meat,
        Vegetation,
        Mixed
    }

    // Enum to classify different types of habitats
    public enum HabitatType
    {
        Desert,
        Forest,
        Aquatic
    }

    // Struct to represent dietary information for animals
    public struct DietInfo
    {
        public FoodType FoodType;
        public string FeedingSchedule;
    }

    // Abstract class representing general animal behaviors
    public abstract class Animal
    {
        // Private fields encapsulated with properties
        private string _name;
        private int _age;
        private string _sound;
        private string _movement;
        private AnimalType _animalType;
        private FoodType _foodType;
        private HabitatType _habitatType;
        private string _species; // Added Species property

        // Public properties with specific get and set requirements
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Sound
        {
            get { return _sound; }
            set { _sound = value; }
        }

        public string Movement
        {
            get { return _movement; }
            set { _movement = value; }
        }

        public AnimalType AnimalType
        {
            get { return _animalType; }
            set { _animalType = value; }
        }

        public FoodType FoodType
        {
            get { return _foodType; }
            set { _foodType = value; }
        }

        public HabitatType HabitatType
        {
            get { return _habitatType; }
            set { _habitatType = value; }
        }

        public string Species // Added Species property
        {
            get { return _species; }
            set { _species = value; }
        }

        // Abstract methods representing general animal behaviors
        public abstract void Eat(DietInfo dietInfo);
        public abstract void Move();
        public abstract void Speak();
    }
}
