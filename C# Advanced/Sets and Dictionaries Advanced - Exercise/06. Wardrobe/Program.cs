namespace _06._Wardrobe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> clothes = new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] models = input[1].Split(",");

                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }

                foreach (var model in models)
                {
                    if (!clothes[color].ContainsKey(model))
                    {
                        clothes[color].Add(model, 0);
                    }

                    clothes[color][model]++;
                }
            }

            string[] lookingFor = Console.ReadLine().Split();

            foreach (var color in clothes)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var model in color.Value)
                {
                    Console.Write($"* {model.Key} - {model.Value}");

                    if (color.Key == lookingFor[0] && model.Key == lookingFor[1])
                    {
                        Console.Write(" (found!)");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
