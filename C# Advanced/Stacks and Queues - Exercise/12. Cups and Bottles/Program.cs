namespace _12._Cups_and_Bottles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int wastedWater = 0;

            while (bottles.Any() && cups.Any())
            {
                int currentCup = cups.Peek();

                while (currentCup > 0 && bottles.Any())
                {
                    int currentBottle = bottles.Pop();

                    if (currentBottle > currentCup)
                    {
                        wastedWater += currentBottle - currentCup;
                    }

                    currentCup -= currentBottle;
                }

                if (currentCup <= 0)
                {
                    cups.Dequeue();
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
