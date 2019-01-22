namespace _05._Supermarket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Supermarket
    {
        static void Main()
        {
            Queue<string> customers = new Queue<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Paid")
                {
                    while (customers.Count != 0)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
