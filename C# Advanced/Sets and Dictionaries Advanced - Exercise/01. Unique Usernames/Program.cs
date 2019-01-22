namespace _01._Unique_Usernames
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            HashSet<string> userNames = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                userNames.Add(Console.ReadLine());
            }

            Console.WriteLine(string.Join(Environment.NewLine, userNames));
        }
    }
}
