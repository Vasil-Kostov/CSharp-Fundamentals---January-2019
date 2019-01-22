namespace _05._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine()
                               .Split(", ")
                               .Select(int.Parse)
                               .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] row = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[,] maxSumMatrix = new int[2, 2];
            int maxSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1] > maxSum)
                    {
                        maxSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                        maxSumMatrix[0, 0] = matrix[i, j];
                        maxSumMatrix[0, 1] = matrix[i, j + 1];
                        maxSumMatrix[1, 0] = matrix[i + 1, j];
                        maxSumMatrix[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(maxSumMatrix[i , j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}
