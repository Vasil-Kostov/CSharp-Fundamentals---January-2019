namespace _04._Fast_Food
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int food = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Console.WriteLine(orders.ToArray().Max());

            while (orders.Count > 0)
            {
                int order = orders.Peek();

                if (food >= order)
                {
                    food -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
