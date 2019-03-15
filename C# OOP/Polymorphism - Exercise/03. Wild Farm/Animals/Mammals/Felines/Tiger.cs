using System;

namespace WildFarm.Animals.Mammals.Felines
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new InvalidFoodException(this.GetType().Name, food.GetType().Name);
            }

            base.Eat(food, 1);            
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
