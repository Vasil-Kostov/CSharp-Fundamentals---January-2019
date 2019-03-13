namespace FoodShortage
{
    using Interfaces;
    using System;

    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, DateTime birthdate)
        {
            this.name = name;
            this.Birthdate = birthdate;
        }

        public DateTime Birthdate { get; private set; }
    }
}
