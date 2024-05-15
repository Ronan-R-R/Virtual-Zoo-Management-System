using System;

namespace VirtualZooManagementSystem
{
    public class Bird : Animal
    {
        public Bird(string name, int age, string sound, string movement, FoodType foodType, HabitatType habitatType, string species)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Movement = movement;
            AnimalType = AnimalType.Bird;
            this.FoodType = foodType;
            this.HabitatType = habitatType;
            Species = species;
        }

        public override void Eat(DietInfo dietInfo)
        {
            Console.WriteLine($"{Name} the {AnimalType} is pecking at {dietInfo.FoodType}.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the {AnimalType} is {Movement}.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {AnimalType} chirps '{Sound}'.");
        }
    }
}