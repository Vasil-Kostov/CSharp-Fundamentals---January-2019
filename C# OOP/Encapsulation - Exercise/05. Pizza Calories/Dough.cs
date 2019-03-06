namespace _05._Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private decimal weight;
        private decimal caloriesModifier;

        public Dough(string flourType, string bakingTechnique, decimal weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
            this.caloriesModifier = GetCaloriesModifier(flourType.ToLower(), bakingTechnique.ToLower());

        }

        public decimal Calories => this.weight * this.caloriesModifier;

        public string FlourType
        {
            get => this.flourType;

            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get => this.bakingTechnique;

            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public decimal Weight
        {
            get => this.weight;

            private set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        private decimal GetCaloriesModifier(string flurTypeModifier, string bakingTechniqueModifier)
        {
            decimal modifier = 2;

            switch (flurTypeModifier)
            {
                case "white": modifier *= 1.5m; break;
                case "wholegrain": modifier *= 1.0m; break;
            }

            switch (bakingTechniqueModifier)
            {
                case "crispy": modifier *= 0.9m; break;
                case "chewy": modifier *= 1.1m; break;
                case "homemade": modifier *= 1.0m; break;
            }

            return modifier;
        }
    }
}
