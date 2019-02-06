namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();
            List<string> relations = new List<string>();

            string mainPersonInfo = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains('-'))
                {
                    relations.Add(input);
                }
                else
                {
                    string[] personInfo = input.Split();

                    string name = $"{personInfo[0]} {personInfo[1]}";
                    string date = personInfo[2];

                    people.Add(new Person(name, date));
                }

                input = Console.ReadLine();
            }

            Person personToPrint = people.Find(p => p.Name == mainPersonInfo || p.DateOfBirth == mainPersonInfo);

            foreach (var relation in relations)
            {
                string[] relatinParts = relation.Split(" - ");
                string parentInfo = relatinParts[0];
                string childInfo = relatinParts[1];

                if (parentInfo == personToPrint.Name || parentInfo == personToPrint.DateOfBirth)
                {
                    personToPrint.Children.Add(people.Find(p => p.Name == childInfo || p.DateOfBirth == childInfo));
                }
                else if (childInfo == personToPrint.Name || childInfo == personToPrint.DateOfBirth)
                {
                    personToPrint.Parents.Add(people.Find(p => p.Name == parentInfo || p.DateOfBirth == parentInfo));
                }
            }

            Console.WriteLine(personToPrint);
        }
    }
}
