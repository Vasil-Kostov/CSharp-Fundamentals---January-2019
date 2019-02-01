namespace _07._Predicate_For_Names
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int maxLength = int.Parse(Console.ReadLine());

            Predicate<string> filter = x => x.Length <= maxLength;

            Console.WriteLine(string.Join(Environment.NewLine, 
                              Console.ReadLine()
                              .Split()
                              .Where(x => filter(x))));
        }
    }
}
