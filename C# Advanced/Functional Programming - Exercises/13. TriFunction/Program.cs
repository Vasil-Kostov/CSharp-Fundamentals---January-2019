namespace _13._TriFunction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            var names = Console.ReadLine().Split();

            Console.WriteLine(names.FirstOrDefault(n => (n.ToCharArray()
                                                          .Sum(c => (int)c)) >= num));
        }
    }
}
