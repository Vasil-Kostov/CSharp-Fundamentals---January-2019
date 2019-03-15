namespace WildFarm.Animals.Mammals
{
    using System;

    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new InvalidFoodException(this.GetType().Name, food.GetType().Name);
            }

            base.Eat(food, 0.4);
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
