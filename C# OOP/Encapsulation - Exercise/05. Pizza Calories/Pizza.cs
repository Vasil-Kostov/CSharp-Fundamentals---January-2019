namespace _05._Pizza_Calories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name)
        {
            this.Name = name;
            this.toppings = new List<Topping>();
        }

        internal Dough Dough
        {
            set
            {
                this.dough = value;
            }
        }

        public decimal TotalCalories => this.dough.Calories + this.toppings.Sum(t => t.Calories);

        public string Name
        {
            get => this.name;

            private set
            {
                if (value == string.Empty || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }

            this.toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.name} - {this.TotalCalories:F2} Calories.";
        }
    }
}
