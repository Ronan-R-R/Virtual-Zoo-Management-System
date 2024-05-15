using System;

namespace VirtualZooManagementSystem
{
    public class Reptile : Animal
    {
        public Reptile(string name, int age, string sound, string movement, FoodType foodType, HabitatType habitatType)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Movement = movement;
            AnimalType = AnimalType.Reptile;
            this.FoodType = foodType;
            this.HabitatType = habitatType;
        }

        public override void Eat(DietInfo dietInfo)
        {
            Console.WriteLine($"{Name} the {AnimalType} is devouring {dietInfo.FoodType}.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the {AnimalType} is slithering {Movement}.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {AnimalType} hisses '{Sound}'.");
        }
    }
}