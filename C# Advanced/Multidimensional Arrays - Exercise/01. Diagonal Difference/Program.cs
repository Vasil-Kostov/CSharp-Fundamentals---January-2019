namespace _01._Diagonal_Difference
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine()
                            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int mainDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                mainDiagonalSum += matrix[i, i];
            }

            int counterDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                counterDiagonalSum += matrix[n - i - 1, i];
            }

            Console.WriteLine(Math.Abs(mainDiagonalSum - counterDiagonalSum));
        }
    }
}
