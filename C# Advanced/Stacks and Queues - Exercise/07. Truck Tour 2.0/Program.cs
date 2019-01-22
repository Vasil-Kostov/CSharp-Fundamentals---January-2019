namespace _07._Truck_Tour_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfStations = int.Parse(Console.ReadLine());

            Queue<int> fuelLeft = new Queue<int>();

            for (int i = 0; i < numberOfStations; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                fuelLeft.Enqueue(input[0] - input[1]);
            }

            int index = 0;

            while (true)
            {
                Queue<int> copyFuelLeft = new Queue<int>(fuelLeft);
                int currentFuel = -1;

                while (copyFuelLeft.Any())
                {
                    if (copyFuelLeft.Peek() > 0 && currentFuel == -1)
                    {
                        currentFuel = copyFuelLeft.Dequeue();
                        fuelLeft.Enqueue(fuelLeft.Dequeue());
                    }
                    else if (copyFuelLeft.Peek() < 0 && currentFuel == -1)
                    {
                        copyFuelLeft.Enqueue(copyFuelLeft.Dequeue());
                        fuelLeft.Enqueue(fuelLeft.Dequeue());
                        index++;
                    }
                    else
                    {
                        currentFuel += copyFuelLeft.Dequeue();

                        if (currentFuel < 0)
                        {
                            break;
                        }
                    }
                }

                if (currentFuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }

                index++;
            }
        }
    }
}
