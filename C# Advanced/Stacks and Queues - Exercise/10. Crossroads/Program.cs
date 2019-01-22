namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int greenLightTime = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            int passedCars = 0;

            string command = Console.ReadLine();
            
            while (command != "END")
            {
                if (command == "green")
                {
                    if (cars.Any())
                    {
                        int currentGreenTime = greenLightTime;

                        while (currentGreenTime > 0 && cars.Any())
                        {
                            if (currentGreenTime >= cars.Peek().Length)
                            {
                                currentGreenTime -= cars.Dequeue().Length;
                                passedCars++;
                            }
                            else
                            {
                                if (currentGreenTime + freeTime >= cars.Peek().Length)
                                {
                                    cars.Dequeue();
                                    currentGreenTime = 0;
                                    passedCars++;
                                }
                                else
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{cars.Peek()} was hit at {cars.Dequeue()[currentGreenTime + freeTime]}.");
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");
        }
    }
}
