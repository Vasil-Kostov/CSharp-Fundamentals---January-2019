namespace CarManufacturer
{
    using CarManufacturer;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tiresSets = GetTiresList();

            List<Engine> engines = GetEnginesList();

            List<Car> cars = new List<Car>();

            string input;

            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo = input.Split();

                Engine currentCarEngine = engines[int.Parse(carInfo[5])];

                Tire[] currentTiresSet = tiresSets[int.Parse(carInfo[6])];

                cars.Add(new Car(carInfo[0], carInfo[1], int.Parse(carInfo[2])
                                , double.Parse(carInfo[3]), double.Parse(carInfo[4])
                                , currentCarEngine, currentTiresSet));
            }

            foreach (var car in cars.Where(c => c.Year >= 2017 
                                             && c.Engine.HorsePowers > 330 
                                             && (c.Tires[0].Pressure + c.Tires[1].Pressure + c.Tires[2].Pressure + c.Tires[3].Pressure > 9 
                                             && c.Tires[0].Pressure + c.Tires[1].Pressure + c.Tires[2].Pressure + c.Tires[3].Pressure < 10)))
            {

                car.Drive(20);

                Console.WriteLine(car.WhoAmI());
            }

        }

        private static List<Engine> GetEnginesList()
        {
            List<Engine> engines = new List<Engine>();

            string input;
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo = input.Split();

                engines.Add(new Engine(int.Parse(engineInfo[0]), double.Parse(engineInfo[1])));
            }

            return engines;
        }

        private static List<Tire[]> GetTiresList()
        {
            List<Tire[]> tiresSets = new List<Tire[]>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = input.Split();

                Tire[] tireSet = new Tire[4]
                {
                    new Tire(int.Parse(tiresInfo[0]), double.Parse(tiresInfo[1])),
                    new Tire(int.Parse(tiresInfo[2]), double.Parse(tiresInfo[3])),
                    new Tire(int.Parse(tiresInfo[4]), double.Parse(tiresInfo[5])),
                    new Tire(int.Parse(tiresInfo[6]), double.Parse(tiresInfo[7]))
                };

                tiresSets.Add(tireSet);
            }

            return tiresSets;
        }        
    }
}
