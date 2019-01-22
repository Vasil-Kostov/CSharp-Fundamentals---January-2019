namespace _07._Knight_Game
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

            bool allKnightsRemoved = false;
            int removedKnights = 0;

            while (!allKnightsRemoved)
            {
                int[] knightCoordinates = new int[2];
                int knightTargets = 0;

                for (int i = 0; i < n; i++)
                {                    
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i,j] == 'K')
                        {
                            int currentKnightTargets = CountTargets(matrix, i, j);

                            if (currentKnightTargets > knightTargets)
                            {
                                knightTargets = currentKnightTargets;
                                knightCoordinates[0] = i;
                                knightCoordinates[1] = j;
                            }
                        }
                    }
                }

                if (knightTargets > 0)
                {
                    matrix[knightCoordinates[0], knightCoordinates[1]] = 'O';
                    removedKnights++;
                }
                else
                {
                    allKnightsRemoved = true;
                }
            }

            Console.WriteLine(removedKnights);
        }

        private static int CountTargets(char[,] matrix, int i, int j)
        {
            int targets = 0;

            if (i - 2 >= 0 && j - 1 >=0)
            {
                if (matrix[i - 2, j -1] == 'K')
                {
                    targets++;
                }
            }
            if (i - 2 >= 0 && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i - 2, j + 1] == 'K')
                {
                    targets++;
                }
            }
            if (i - 1 >= 0 && j - 2 >= 0)
            {
                if (matrix[i - 1, j - 2] == 'K')
                {
                    targets++;
                }
            }
            if (i - 1 >= 0 && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i - 1, j + 2] == 'K')
                {
                    targets++;
                }
            }
            if (i + 1 < matrix.GetLength(0) && j - 2 >= 0) 
            {
                if (matrix[i + 1, j - 2] == 'K')
                {
                    targets++;
                }
            }
            if (i + 1 < matrix.GetLength(0) && j + 2 < matrix.GetLength(1))
            {
                if (matrix[i + 1, j + 2] == 'K')
                {
                    targets++;
                }
            }
            if (i + 2 < matrix.GetLength(0) && j - 1 >= 0)
            {
                if (matrix[i + 2, j - 1] == 'K')
                {
                    targets++;
                }
            }
            if (i + 2 < matrix.GetLength(0) && j + 1 < matrix.GetLength(1))
            {
                if (matrix[i + 2, j + 1] == 'K')
                {
                    targets++;
                }
            }
            return targets;
        }
    }
}
