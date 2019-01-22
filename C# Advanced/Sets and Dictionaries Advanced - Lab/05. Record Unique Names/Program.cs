namespace _05._Record_Unique_Names
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            HashSet<string> uniqueNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                uniqueNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
        }
    }
}
