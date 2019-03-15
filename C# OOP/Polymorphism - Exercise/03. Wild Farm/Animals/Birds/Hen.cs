namespace WildFarm.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override void Eat(Food food, double weightIncrease)
        {
            base.Eat(food, 0.35);
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
