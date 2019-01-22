namespace _02._Squares_in_Matrix
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            char[,] matrix = new char[dimentions[0], dimentions[1]];

            for (int i = 0; i < dimentions[0]; i++)
            {
                char[] row = Console.ReadLine()
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .Select(char.Parse)
                             .ToArray();

                for (int j = 0; j < dimentions[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int counter = 0;

            for (int i = 0; i < dimentions[0] - 1; i++)
            {
                for (int j = 0; j < dimentions[1] - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i, j] == matrix[i + 1, j] && matrix[i, j] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
