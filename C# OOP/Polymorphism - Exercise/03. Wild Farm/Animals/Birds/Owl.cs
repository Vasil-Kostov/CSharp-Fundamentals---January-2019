namespace WildFarm.Animals.Birds
{
    using System;

    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new InvalidFoodException(this.GetType().Name, food.GetType().Name);
            }

            base.Eat(food, 0.25);
        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
