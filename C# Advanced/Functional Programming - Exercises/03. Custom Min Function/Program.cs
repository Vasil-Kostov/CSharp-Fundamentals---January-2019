namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<int[], int> getMin = n => n.Min();

            Console.WriteLine(getMin(Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray()));                
        }
    }
}
