namespace _02._Sum_Matrix_Columns
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
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int colSum = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    colSum += matrix[row, col];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}
