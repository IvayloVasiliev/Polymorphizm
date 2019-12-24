using System;
using WildFarm.Foods;

namespace WildFarm.Animals.Felines
{
    public class Tiger : Feline
    {
        private const double foodIncrease = 1;
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food is Meat)
            {
                Weight += food.Quantity * foodIncrease;
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"Tiger does not eat {food.GetType().Name}!");
            }
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
