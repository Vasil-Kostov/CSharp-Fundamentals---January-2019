namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            decimal[] inputValues = Console.ReadLine()
                                    .Split()
                                    .Select(decimal.Parse)
                                    .ToArray();

            Dictionary<decimal, int> counter = new Dictionary<decimal, int>();

            foreach (var value in inputValues)
            {
                if (!counter.ContainsKey(value))
                {
                    counter.Add(value, 0);
                }

                counter[value]++;
            }

            foreach (var value in counter)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
