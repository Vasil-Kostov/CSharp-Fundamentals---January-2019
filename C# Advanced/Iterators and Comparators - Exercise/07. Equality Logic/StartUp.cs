namespace _07._Equality_Logic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();

            HashSet<Person> hashedPeople = new HashSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Person currentPerson = new Person(input[0], int.Parse(input[1]));

                sortedPeople.Add(currentPerson);
                hashedPeople.Add(currentPerson);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }
    }
}
