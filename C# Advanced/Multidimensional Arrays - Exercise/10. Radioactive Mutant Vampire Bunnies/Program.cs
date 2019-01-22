namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[][] matrix = new char[dimentions[0]][];
            int playerRow = 0;
            int playerCol = 0;

            for (int i = 0; i < dimentions[0]; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();

                if (matrix[i].Contains('P'))
                {
                    playerRow = i;
                    playerCol = Array.IndexOf(matrix[i], 'P');
                    matrix[playerRow][playerCol] = '.';
                }
            }

            string moves = Console.ReadLine();
            
            foreach (var move in moves)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;

                switch (move)
                {
                    case 'U':
                        newPlayerRow -= 1;
                        break;
                    case 'R':
                        newPlayerCol += 1;
                        break;
                    case 'L':
                        newPlayerCol -= 1;
                        break;
                    case 'D':
                        newPlayerRow += 1;
                        break;
                    default:
                        break;
                }

                matrix = SpreadTheBunnies(matrix, dimentions[0], dimentions[1]);

                if (newPlayerRow >= 0 && newPlayerRow < dimentions[0]
                    && newPlayerCol >= 0 && newPlayerCol < dimentions[1])
                {
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;


                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        PrintTheMatrix(matrix);
                        Console.WriteLine($"dead: {playerRow} {playerCol}");
                        return;
                    }
                }
                else
                {
                    PrintTheMatrix(matrix);
                    Console.WriteLine($"won: {playerRow} {playerCol}");
                    return;
                }
            }
        }

        private static void PrintTheMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join("", row));
            }
        }

        private static char[][] SpreadTheBunnies(char[][] matrix, int rows, int cols)
        {
            char[][] newMatrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                newMatrix[i] = matrix[i].ToArray();                
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        if (i - 1 >= 0)
                        {
                            newMatrix[i - 1][j] = 'B';
                        }
                        if (i + 1 < rows)
                        {
                            newMatrix[i + 1][j] = 'B';
                        }
                        if (j - 1 >= 0)
                        {
                            newMatrix[i][j - 1] = 'B';
                        }
                        if (j + 1 < cols )
                        {
                            newMatrix[i][j + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }
    }
}
