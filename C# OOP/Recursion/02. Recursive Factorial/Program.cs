namespace _02._Recursive_Factorial
{
    using System;

    public class Program
    {
        public static long Factorial(int number)
        {
            if (number == 2)
            {
                return 2;
            }

            return number * Factorial(number - 1);
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(Factorial(n));
        }
    }
}
