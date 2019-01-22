namespace _02._Sets_of_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            HashSet<string> firstSet = new HashSet<string>();
            HashSet<string> secondSet = new HashSet<string>();

            int[] setsLength = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < setsLength.Sum(); i++)
            {
                if (i < setsLength[0])
                {
                    firstSet.Add(Console.ReadLine());
                }
                else
                {
                    secondSet.Add(Console.ReadLine());
                }
            }

            Console.WriteLine(string.Join(" ", firstSet.Where(i => secondSet.Contains(i))));
        }
    }
}
