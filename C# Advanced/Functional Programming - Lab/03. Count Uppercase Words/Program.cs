namespace _03._Count_Uppercase_Words
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine, Console.ReadLine()
                              .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                              .Where(x => char.IsUpper(x[0]))));
        }
    }
}
