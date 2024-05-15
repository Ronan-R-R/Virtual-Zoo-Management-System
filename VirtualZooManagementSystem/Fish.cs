using System;

namespace VirtualZooManagementSystem
{
    public class Fish : Animal
    {
        public Fish(string name, int age, string sound, string movement, FoodType foodType, HabitatType habitatType)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Movement = movement;
            AnimalType = AnimalType.Fish;
            this.FoodType = foodType;
            this.HabitatType = habitatType;
        }

        public override void Eat(DietInfo dietInfo)
        {
            Console.WriteLine($"{Name} the {AnimalType} is nibbling on {dietInfo.FoodType}.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} the {AnimalType} is swimming {Movement}.");
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} the {AnimalType} makes no sound.");
        }
    }
}
