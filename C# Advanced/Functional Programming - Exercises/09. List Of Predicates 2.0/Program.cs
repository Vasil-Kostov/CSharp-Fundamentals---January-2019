namespace _09._List_Of_Predicates_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int lastNum = int.Parse(Console.ReadLine());

            var divisors = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, bool> filter = (x, y) => x % y == 0;

            var result = new List<int>();

            bool isDivisible = true;

            for (int i = 1; i <= lastNum; i++)
            {
                for (int j = 0; j < divisors.Count(); j++)
                {
                    if (!filter(i, divisors[j]))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }

                isDivisible = true;
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
