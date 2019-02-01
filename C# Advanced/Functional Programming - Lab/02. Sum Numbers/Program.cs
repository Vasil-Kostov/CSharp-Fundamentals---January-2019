namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, new int[] {input.Count(), input.Sum()}));
        }
    }
}
