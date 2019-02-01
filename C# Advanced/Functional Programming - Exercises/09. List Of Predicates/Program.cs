namespace _09._List_Of_Predicates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main() // 80/100 Memory limit
        {
            int lastNum = int.Parse(Console.ReadLine());

            var numbers = Enumerable.Range(1, lastNum > 0 ? lastNum : 0);

            var divisors = Console.ReadLine().Split().Select(int.Parse);

            Predicate<int> filter = x => divisors.All(d => x % d == 0);

            Console.WriteLine(string.Join(" ", numbers.Where(x => filter(x))));
        }
    }
}
