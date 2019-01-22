namespace _11._Key_Revolver
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            int initialBulets = bullets.Count;

            int recipeValue = int.Parse(Console.ReadLine());

            while (locks.Any())
            {
                for (int i = 0; i < barrelSize; i++)
                {
                    if (bullets.Any())
                    {
                        int bullet = bullets.Pop();

                        if (bullet <= locks.Peek())
                        {
                            Console.WriteLine("Bang!");
                            locks.Dequeue();

                            if (locks.Count == 0)
                            {
                                if (i == barrelSize - 1 && bullets.Any())
                                {
                                    Console.WriteLine("Reloading!");
                                }

                                Console.WriteLine($"{bullets.Count} bullets left. Earned ${recipeValue - (initialBulets - bullets.Count) * bulletPrice}");
                                return;
                            }
                        }
                        else
                        { 
                            Console.WriteLine("Ping!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        return;
                    }
                }

                if (bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

        }
    }
}
