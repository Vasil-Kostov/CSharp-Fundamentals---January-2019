namespace DefinintgClasses
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] currentCarInfo = Console.ReadLine().Split();

                cars.Add(new Car(currentCarInfo[0], double.Parse(currentCarInfo[1]), double.Parse(currentCarInfo[2])));
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                cars.Find(c => c.Model == command[1]).Drive(int.Parse(command[2]));

                command = Console.ReadLine().Split();
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TtraveledKM}");
            }
        }
    }
}
