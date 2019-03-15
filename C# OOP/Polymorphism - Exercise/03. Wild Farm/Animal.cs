namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public virtual void Eat(Food food, double weightIncrease)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * weightIncrease;
        }

        public virtual string ProduceSound()
        {
            return "Sound";
        }

        public string Name { get; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }        
    }
}
