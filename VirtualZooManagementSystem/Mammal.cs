using System;

namespace VirtualZooManagementSystem
{
    public class Mammal : Animal
    {
        public Mammal(string name, int age, string sound, string movement, FoodType foodType, HabitatType habitatType, string species)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Movement = movement;
            AnimalType = AnimalType.Mammal;
            this.FoodType = foodType;
            this.HabitatType = habitatType;
            Species = species;
        }

        public override void Eat(DietInfo dietInfo)
        {
            Console.WriteLine($"{Name} the {AnimalType} is eating {dietInfo.FoodType}.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the {AnimalType} is {Movement}.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {AnimalType} says '{Sound}'.");
        }
    }
}