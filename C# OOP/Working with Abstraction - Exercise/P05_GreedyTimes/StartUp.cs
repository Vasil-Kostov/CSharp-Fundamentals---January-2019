namespace P05_GreedyTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            long capacity = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var bag = new Bag(capacity);

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long amount = long.Parse(safe[i + 1]);

                var item = new Item(name, amount);

                if (item.Type == "Gold" || item.Type == "Gem" || item.Type == "Cash")
                {
                    bag.AddItem(item);
                }
            }

            Console.WriteLine(bag);
        }
    }
}