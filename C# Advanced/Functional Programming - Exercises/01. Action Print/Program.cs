namespace _01._Action_Print
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Action<string> printAction = s => Console.WriteLine(s);

            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(printAction);
        }
    }
}
