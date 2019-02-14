namespace _05._Comparing_Objects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "END")
            {
                people.Add(new Person(input[0], int.Parse(input[1]), input[2]));

                input = Console.ReadLine().Split();
            }

            int indexOfPersonToCompare = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[indexOfPersonToCompare];

            int equalPeople = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine($"{equalPeople} {people.Count - equalPeople} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
