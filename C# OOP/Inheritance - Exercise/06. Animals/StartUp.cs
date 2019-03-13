namespace _06._Animals
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        static void Main()
        {
            List<Animal> animals = new List<Animal>();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "Beast!")
                {
                    break;
                }

                string animalType = inputLine;
                string[] animalInfo = Console.ReadLine().Split();

                try
                {
                    Animal animal = AnimalFactory.Create(animalType, animalInfo[0]
                                         , int.Parse(animalInfo[1]), animalInfo[2]);

                    animals.Add(animal);
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
