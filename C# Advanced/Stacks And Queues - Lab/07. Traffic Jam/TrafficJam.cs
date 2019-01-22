namespace _07._Traffic_Jam
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class TrafficJam
    {
        static void Main()
        {
            int passingCars = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            int passedCars = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    int currentPassingCars = Math.Min(cars.Count, passingCars);

                    for (int i = 0; i < currentPassingCars; i++)
                    {
                        sb.AppendLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            sb.AppendLine($"{passedCars} cars passed the crossroads.");

            Console.Write(sb);
        }
    }
}
