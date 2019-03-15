namespace _01._Recursive_Array_Sum
{
    using System;
    using System.Linq;

    public class Program
    {
        public static int Sum(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }

            return array[index] + Sum(array, index + 1);
        }

        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(Sum(numbers, 0));
        }
    }
}
