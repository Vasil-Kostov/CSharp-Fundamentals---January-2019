namespace _06._Auto_Repair_and_Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<string> carsToServe = new Queue<string>(Console.ReadLine().Split(new char[] { ' ', '\t' }));
            Stack<string> servedCars = new Stack<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service")
                {
                    if (carsToServe.Any())
                    {
                        Console.WriteLine($"Vehicle {carsToServe.Peek()} got served.");
                        servedCars.Push(carsToServe.Dequeue());
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
                else
                {
                    string car = command.Split('-').Last();

                    if (servedCars.Contains(car))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if (carsToServe.Contains(car))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }

                command = Console.ReadLine();
            }

            if (carsToServe.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsToServe)}");
            }

            if (servedCars.Any())
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
