namespace FoodShortage
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] args = Console.ReadLine().Split();

                if (args.Length == 4)
                {
                    DateTime birthdate = DateTime.ParseExact(args[3], "dd/MM/yyyy", null);

                    buyers.Add(args[0], new Citizen(args[0], int.Parse(args[1]), args[2], birthdate));
                }
                else if (args.Length == 3)
                {
                    buyers.Add(args[0], new Rebel(args[0], int.Parse(args[1]), args[2]));
                }
            }

            string name = Console.ReadLine();

            while (name != "End")
            {
                try
                {
                    buyers[name].BuyFood();
                }
                catch
                {
                }

                name = Console.ReadLine();
            }

            Console.WriteLine(buyers.Values.Sum(b => b.Food));
        }
    }
}
