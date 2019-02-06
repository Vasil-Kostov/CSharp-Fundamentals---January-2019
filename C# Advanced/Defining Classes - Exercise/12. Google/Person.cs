namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private Company company;
        private Car car;
        private List<Parent> parents;
        private List<Child> children;
        private List<Pokemon> pokemons;

        public Person(string name)
        {
            this.Name = name;
            this.Parents = new List<Parent>();
            this.Children = new List<Child>();
            this.Pokemons = new List<Pokemon>();
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();

            personInfo.AppendLine($"{this.Name}");

            personInfo.AppendLine($"Company:");
            if (this.company != null) personInfo.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:F2}");

            personInfo.AppendLine($"Car:");
            if (this.Car != null) personInfo.AppendLine($"{this.Car.Model} {this.Car.Speed}");

            personInfo.AppendLine($"Pokemon:");
            if (this.Pokemons.Any()) this.Pokemons.ForEach(p => personInfo.AppendLine($"{p.Name} {p.Type}"));

            personInfo.AppendLine($"Parents:");
            if (this.Parents.Any()) this.Parents.ForEach(p => personInfo.AppendLine($"{p.Name} {p.DateOfBirth}"));

            personInfo.AppendLine($"Children:");
            if (this.Children.Any()) this.Children.ForEach(c => personInfo.AppendLine($"{c.Name} {c.DateOfBirth}"));

            return personInfo.ToString();
        }
    }
}
