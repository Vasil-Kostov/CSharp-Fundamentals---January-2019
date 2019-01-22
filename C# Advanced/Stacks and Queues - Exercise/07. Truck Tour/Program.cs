namespace _07._Truck_Tour
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main() // 80/100 (Memory limit)
        {
            int numberOfStations = int.Parse(Console.ReadLine());

            Queue<int> fuelLeft = new Queue<int>();

            for (int i = 0; i < numberOfStations; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                fuelLeft.Enqueue(input[0] - input[1]);
            }

            for (int i = 0; i < fuelLeft.Count; i++)
            {
                Queue<int> copyFuelLeft = new Queue<int>(fuelLeft);

                int currentFuel = 0;


                for (int j = 0; j < copyFuelLeft.Count; j++)
                {
                    currentFuel += copyFuelLeft.Dequeue();

                    if (currentFuel < 0)
                    {
                        break;
                    }

                }

                if (currentFuel >= 0)
                {
                    Console.WriteLine(i);
                    return;
                }

                fuelLeft.Enqueue(fuelLeft.Dequeue());
            }
        }
    }
}
