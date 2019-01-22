namespace _01._Sum_Matrix_Elements
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

            Console.WriteLine(rows);
            Console.WriteLine(cols);

            int sum = 0;

            foreach (var item in matrix)
            {
                sum += item;
            }

            Console.WriteLine(sum);
        }
    }
}
