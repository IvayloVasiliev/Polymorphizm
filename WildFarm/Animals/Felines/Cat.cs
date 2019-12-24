using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Felines
{
    public class Cat : Feline
    {
        private const double foodIncrease = 0.3;
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable || food is Meat)
            {
                Weight += food.Quantity * foodIncrease;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Cat does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
