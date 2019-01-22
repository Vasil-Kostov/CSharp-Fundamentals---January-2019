namespace _04._Symbol_in_Matrix
{
    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().ToCharArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] == symbol)
                    {
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
