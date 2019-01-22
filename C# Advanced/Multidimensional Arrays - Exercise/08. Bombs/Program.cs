namespace _08._Bombs
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
                matrix[i] = row;
            }

            string[] bombs = Console.ReadLine().Split();

            foreach (var item in bombs)
            {
                int[] bombCoordinates = item.Split(",").Select(int.Parse).ToArray();

                if (bombCoordinates[0] >= 0 && bombCoordinates[0] < n && bombCoordinates[1] >= 0 && bombCoordinates[1] < n
                    && matrix[bombCoordinates[0]][bombCoordinates[1]] > 0)
                {
                    matrix = Explosion(matrix, bombCoordinates, n);
                }
            }

            int aliveCells = 0;
            int sumOfAliveCells = 0;

            StringBuilder sb = new StringBuilder();

            foreach (var row in matrix)
            {
                foreach (var cell in row)
                {
                    if (cell > 0)
                    {
                        aliveCells++;
                        sumOfAliveCells += cell;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumOfAliveCells}");

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }

        private static int[][] Explosion(int[][] matrix, int[] bombCoordinates, int n)
        {
            int bombPower = matrix[bombCoordinates[0]][bombCoordinates[1]];

            for (int i = bombCoordinates[0] - 1; i <= bombCoordinates[0] + 1; i++)
            {
                for (int j = bombCoordinates[1] - 1; j <= bombCoordinates[1] + 1; j++)
                {
                    if (i >= 0 && i < n && j >= 0 && j < n && matrix[i][j] > 0)
                    {
                        matrix[i][j] -= bombPower;
                    }
                }
            }

            return matrix;
        }
    }
}
