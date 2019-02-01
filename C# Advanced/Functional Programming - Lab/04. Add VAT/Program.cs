namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(Environment.NewLine,
                              Console.ReadLine()
                              .Split(", ")
                              .Select(double.Parse)
                              .Select(x => x * 1.2)
                              .Select(x => $"{x:F2}")));
        }
    }
}
