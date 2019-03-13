namespace ExplicitInterfaces
{
    using ExplicitInterfaces.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Citizen : IResident, IPerson
    {
        public Citizen(string name, string counrty, int age)
        {
            this.Name = name;
            this.Country = counrty;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Country { get; private set; }

        public string GetName()
        {
            return $"{this.Name}";
        }

        string IResident.GetName()
        {
            return $"Mr/Ms/Mrs {this.Name}";
        }
    }
}
