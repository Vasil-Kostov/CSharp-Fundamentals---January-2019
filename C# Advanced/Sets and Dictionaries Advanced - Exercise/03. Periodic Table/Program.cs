namespace _03._Periodic_Table
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            SortedSet<string> elements = new SortedSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] compound = Console.ReadLine().Split();

                foreach (var element in compound)
                {
                    elements.Add(element);
                }
            }

            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
