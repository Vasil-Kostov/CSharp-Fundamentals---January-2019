namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Person> stalkedPeople = new List<Person>();

            string[] inputArr = Console.ReadLine().Split();

            while (inputArr[0] != "End")
            {
                if (!stalkedPeople.Any(p => p.Name == inputArr[0]))
                {
                    stalkedPeople.Add(new Person(inputArr[0]));
                }

                switch (inputArr[1])
                {
                    case "company":
                        stalkedPeople.Find(p => p.Name == inputArr[0])
                            .Company = new Company(inputArr[2], inputArr[3], decimal.Parse(inputArr[4]));
                        break;

                    case "pokemon":
                        stalkedPeople.Find(p => p.Name == inputArr[0])
                            .Pokemons.Add(new Pokemon(inputArr[2], inputArr[3]));
                        break;

                    case "parents":
                        stalkedPeople.Find(p => p.Name == inputArr[0])
                            .Parents.Add(new Parent(inputArr[2], inputArr[3]));
                        break;

                    case "children":
                        stalkedPeople.Find(p => p.Name == inputArr[0])
                            .Children.Add(new Child(inputArr[2], inputArr[3]));
                        break;

                    case "car":
                        stalkedPeople.Find(p => p.Name == inputArr[0])
                            .Car = new Car(inputArr[2], int.Parse(inputArr[3]));
                        break;
                }

                inputArr = Console.ReadLine().Split();
            }

            string nameToPrint = Console.ReadLine();

            Console.WriteLine(stalkedPeople.Find(p => p.Name == nameToPrint));
        }
    }
}
