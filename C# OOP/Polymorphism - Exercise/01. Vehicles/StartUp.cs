namespace Vehicles
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));

            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine().Split();

                if (commandArr[0] == "Drive")
                {
                    if (commandArr[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(double.Parse(commandArr[2])));
                    }
                    else
                    {
                        Console.WriteLine(truck.Drive(double.Parse(commandArr[2])));
                    }
                }
                else
                {
                    if (commandArr[1] == "Car")
                    {
                        car.Refuel(double.Parse(commandArr[2]));
                    }
                    else
                    {
                        truck.Refuel(double.Parse(commandArr[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelLef:F2}");
            Console.WriteLine($"Truck: {truck.FuelLef:F2}");
        }
    }
}
