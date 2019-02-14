namespace _06._Strategy_Pattern
{
    using StratrgyPattern;
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> sortedByName = new SortedSet<Person>(new NameLengthComparer());
            SortedSet<Person> sortedByAge = new SortedSet<Person>(new AgeComparer());

            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                sortedByName.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
                sortedByAge.Add(new Person(personInfo[0], int.Parse(personInfo[1])));
            }

            Console.WriteLine(string.Join(Environment.NewLine,sortedByName));
            Console.WriteLine(string.Join(Environment.NewLine,sortedByAge));
        }
    }
}
