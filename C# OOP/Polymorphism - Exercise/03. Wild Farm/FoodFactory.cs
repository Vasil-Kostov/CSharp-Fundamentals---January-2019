namespace WildFarm
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WildFarm.Foods;

    public static class FoodFactory
    {
        public static Food CreateFood(params string[] foodInfo)
        {
            switch (foodInfo[0])
            {
                case "Vegetable": return new Vegetable(int.Parse(foodInfo[1]));
                case "Fruit": return new Fruit(int.Parse(foodInfo[1]));
                case "Meat": return new Meat(int.Parse(foodInfo[1]));
                case "Seeds": return new Seeds(int.Parse(foodInfo[1]));
                default: return null;
            }
        }
    }
}
