namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();

            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                cars.Add(new Car(Console.ReadLine().Split()));
            }

            if (Console.ReadLine() == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.TireSet.Any(t => t.Pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
            else
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250).ToList().ForEach(c => Console.WriteLine(c.Model));
            }
        }
    }
}
