namespace WildFarm.Animals.Mammals.Felines
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            if (food.GetType().Name != "Meat" && food.GetType().Name != "Vegetable")
            {
                throw new InvalidFoodException(this.GetType().Name, food.GetType().Name);
            }
                
            base.Eat(food, 0.3);
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
