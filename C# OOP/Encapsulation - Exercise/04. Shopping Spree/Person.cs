namespace _04._Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.bag = new List<Product>();
        }

        public decimal Money
        {
            get => this.money;

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }

                this.money = value;
            }
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (value == string.Empty || value == null || value == " ")
                {
                    throw new ArgumentException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public void BuyProduct(Product product)
        {
            if (product.Cost > this.money)
            {
                throw new InvalidOperationException($"{this.Name} can't afford {product.Name}");
            }

            this.bag.Add(product);

            this.money -= product.Cost;
        }

        public override string ToString()
        {
            if (this.bag.Any())
            {
                return $"{this.name} - {string.Join(", ", this.bag)}";
            }
            else
            {
                return $"{this.name} - Nothing bought";
            }
        }
    }
}
