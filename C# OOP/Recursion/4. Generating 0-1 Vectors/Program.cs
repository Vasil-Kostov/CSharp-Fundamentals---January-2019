namespace _4._Generating_0_1_Vectors
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Generate(int[] array, int index)
        {
            if (index  >= array.Length)
            {
                Console.WriteLine(string.Join("", array));
                return;
            }

            for (int i = 0; i <= 1; i++)
            {
                array[index] = i;
                Generate(array, index + 1);
            }
        }

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Generate(new int[n], 0);
        }
    }
}
