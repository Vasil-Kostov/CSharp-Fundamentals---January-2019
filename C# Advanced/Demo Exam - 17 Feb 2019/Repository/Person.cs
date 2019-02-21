namespace Repository
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Person
    {
        public Person(string name, int Age, DateTime birthdate)
        {
            this.Name = name;
            this.Age = Age;
            this.Birthdate = birthdate;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
