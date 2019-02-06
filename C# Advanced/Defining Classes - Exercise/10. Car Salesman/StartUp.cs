namespace DefiningClasses
{ 
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();

            int numberOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEngines; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (engineInfo.Length == 3)
                {
                    if (int.TryParse(engineInfo[2], out int displacement))
                    {
                       engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), displacement));
                    }
                    else
                    {
                        engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), engineInfo[2]));
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1]), int.Parse(engineInfo[2]), engineInfo[3]));
                }
                else
                {
                    engines.Add(new Engine(engineInfo[0], int.Parse(engineInfo[1])));
                }
            }

            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Engine currentCarEngine = engines.Find(e => e.Model == carInfo[1]);

                if (carInfo.Length == 3)
                {
                    if (int.TryParse(carInfo[2], out int weight))
                    {
                        cars.Add(new Car(carInfo[0], currentCarEngine, weight));
                    }
                    else
                    {
                        cars.Add(new Car(carInfo[0], currentCarEngine, carInfo[2]));
                    }
                }
                else if (carInfo.Length == 4)
                {
                    cars.Add(new Car(carInfo[0], currentCarEngine, int.Parse(carInfo[2]), carInfo[3]));
                }
                else
                {
                    cars.Add(new Car(carInfo[0], currentCarEngine));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
