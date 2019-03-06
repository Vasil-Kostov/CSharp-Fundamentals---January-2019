namespace _05._Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Topping
    {
        private string type;
        private decimal weight;
        private decimal caloriesModifier;

        public Topping(string type, decimal weight)
        {
            this.Type = type;
            this.Weight = weight;
            this.caloriesModifier = GetCaloriesModifier(type.ToLower());
        }

        public decimal Calories => this.weight * this.caloriesModifier;

        public string Type
        {
            get => this.type;

            private set
            {
                if (value.ToLower() != "meat" && value.ToLower() != "veggies" 
                    && value.ToLower() != "cheese" && value.ToLower() != "sauce")
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.type = value;
            }
        }

        public decimal Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.type} weight should be in the range [1..50].");
                }

                this.weight = value;
            }
        }

        private decimal GetCaloriesModifier(string typeModifier)
        {
            decimal modifier = 2;

            switch (typeModifier)
            {
                case "meat": modifier *= 1.2m; break;
                case "veggies": modifier *= 0.8m; break;
                case "cheese": modifier *= 1.1m; break;
                case "sauce": modifier *= 0.9m; break;    
            }

            return modifier;
        }
    }
}
