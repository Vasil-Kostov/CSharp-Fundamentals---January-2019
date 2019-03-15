namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            if (food.GetType().Name != "Fruit" && food.GetType().Name != "Vegetable")
            {
                throw new InvalidFoodException(this.GetType().Name, food.GetType().Name);
            }

            base.Eat(food, 0.1);
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
