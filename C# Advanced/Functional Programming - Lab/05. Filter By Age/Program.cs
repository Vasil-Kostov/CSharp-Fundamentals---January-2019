namespace _05._Filter_By_Age
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public  Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] currentPerson = Console.ReadLine().Split(", ");

                people.Add(new Person(currentPerson[0], int.Parse(currentPerson[1])));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            string printFormat = Console.ReadLine();

            Action<Person> printAction;

            if (printFormat == "name age")
            {
                printAction = p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
            else if (printFormat == "name")
            {
                printAction = p => Console.WriteLine(p.Name);
            }
            else
            {
                printAction = p => Console.WriteLine(p.Age);
            }

            people
                .Where(filterPredicate)
                .ToList()
                .ForEach(printAction);

        }
    }
}
