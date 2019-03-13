namespace BirthdayCelebrations
{
    using System;

    public class Citizen : IIdentifiable, IBirthable
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
    }
}
