using System;

namespace WildFarm.Animals.Mammals.Factory
{
    public class MammalFactory
    {
        public Mammal CreateMammal(string type, string name, double weight,
            string livinRegion)
        {
            type = type.ToLower();

            switch (type)
            {
                case "dog":
                    return new Dog( name, weight, livinRegion);
                case "mouse":
                    return new Mouse(name, weight, livinRegion);

                default:
                    return null;
            }

        }


    }
}
