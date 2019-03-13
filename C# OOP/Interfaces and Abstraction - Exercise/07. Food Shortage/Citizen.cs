namespace FoodShortage
{
    using Interfaces;
    using System;

    public class Citizen : IIdentifiable, IBirthable, IBuyer
    {
        private string name;
        private int age;

        public Citizen(string name, int age, string id, DateTime birthdate)
        {
            this.name = name;
            this.age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; private set; }

        public DateTime Birthdate { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
