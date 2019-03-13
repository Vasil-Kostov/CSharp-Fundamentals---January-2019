namespace MordorsCruelPlan.Factories
{
    using Foods;

    public abstract class FoodFactory
    {
        public static Food CreateFood(string type)
        {
            switch (type.ToLower())
            {
                case "apple": return new Apple();
                case "melon": return new Melon();
                case "cram": return new Cram();
                case "lembas": return new Lembas();
                case "honeycake": return new HoneyCake();
                case "mushrooms": return new Mushrooms();
                default: return new Food();
            }
        }
    }
}
