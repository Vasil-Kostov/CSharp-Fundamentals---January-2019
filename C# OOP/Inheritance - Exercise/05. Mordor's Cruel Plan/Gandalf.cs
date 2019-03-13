namespace MordorsCruelPlan
{
    using Foods;
    using Moods;
    using MordorsCruelPlan.Factories;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Gandalf
    {
        private List<Food> foods;
        private int happinessPoints;
        private Mood mood => MoodFactory.CreateMood(this.happinessPoints);

        public Gandalf()
        {
            this.foods = new List<Food>();
        }

        public void Eat(params string[] foods)
        {
            foreach (var food in foods)
            {
                this.foods.Add(FoodFactory.CreateFood(food.ToLower()));
            }

            this.happinessPoints += this.foods.Sum(f => f.PointsOfHappiness);
        }

        public override string ToString()
        {
            return $"{this.happinessPoints}{Environment.NewLine}{this.mood.GetType().Name}".Trim();
        }
    }
}
