namespace VehiclesExtension
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] carInfo = Console.ReadLine().Split();
            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));

            string[] truckInfo = Console.ReadLine().Split();
            Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));

            string[] busInfo = Console.ReadLine().Split();
            Vehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commandArr = Console.ReadLine().Split();

                try
                {
                    if (commandArr[1] == "Car")
                    {
                        if (commandArr[0] == "Drive")
                        {
                            Console.WriteLine(car.Drive(double.Parse(commandArr[2])));
                        }
                        else
                        {
                            car.Refuel(double.Parse(commandArr[2]));
                        }
                    }
                    else if (commandArr[1] == "Truck")
                    {
                        if (commandArr[0] == "Drive")
                        {
                            Console.WriteLine(truck.Drive(double.Parse(commandArr[2])));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(commandArr[2]));
                        }
                    }
                    else
                    {
                        if (commandArr[0] == "Refuel")
                        {
                            bus.Refuel(double.Parse(commandArr[2]));
                        }
                        else
                        {
                            Console.WriteLine(((Bus)bus).Drive(double.Parse(commandArr[2]), commandArr[0]));
                        }
                    }

                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelLef:F2}");
            Console.WriteLine($"Truck: {truck.FuelLef:F2}");
            Console.WriteLine($"Bus: {bus.FuelLef:F2}");
        }
    }
}
