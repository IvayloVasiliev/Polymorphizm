using System;

namespace WildFarm.Animals.Felines.Factory
{
    public class FelineFactory
    {
        public Feline CreateFeline(string type, string name, double weight, string livinRegion,
            string breed)
        {
            type = type.ToLower();

            switch (type)
            {
                case "cat":
                    return new Cat(name, weight, livinRegion, breed);
                case "tiger":
                    return new Tiger(name, weight, livinRegion, breed);

                default:
                    return null;
            }


        }

    }
}
