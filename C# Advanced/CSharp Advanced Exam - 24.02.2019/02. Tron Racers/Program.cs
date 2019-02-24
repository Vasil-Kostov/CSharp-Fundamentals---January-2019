namespace _02._Tron_Racers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int[] firesPlayer = new int[2];
            int[] secondPlayer = new int[2];

            char firstPlayerSymbol = 'f';
            char seconPlayerSymbol = 's';

            int size = int.Parse(Console.ReadLine());

            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();

                if (matrix[i].Contains('f'))
                {
                    firesPlayer[0] = i;
                    firesPlayer[1] = Array.IndexOf(matrix[i], firstPlayerSymbol);
                }

                if (matrix[i].Contains('s'))
                {
                    secondPlayer[0] = i;
                    secondPlayer[1] = Array.IndexOf(matrix[i], seconPlayerSymbol);
                }
            }

            bool isAliveFirstPlayer = true;
            bool isAliveSecondPlayer = true;

            while (true)
            {
                string[] directions = Console.ReadLine().Split();

                isAliveFirstPlayer = Move(matrix, directions[0], firesPlayer, firstPlayerSymbol, seconPlayerSymbol);

                if (!isAliveFirstPlayer) break;

                isAliveSecondPlayer = Move(matrix, directions[1], secondPlayer, seconPlayerSymbol, firstPlayerSymbol);

                if (!isAliveSecondPlayer) break;
            }

            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
        }

        private static bool Move(char[][] matrix, string direction, int[] player, char playerSymbol, char otherPlayerSymbol)
        {
            int[] nextPositon = new int[2];

            switch (direction)
            {
                case "down":
                    nextPositon[0] = (player[0] + 1 < matrix.GetLength(0)) ? player[0] + 1 : 0;
                    nextPositon[1] = player[1];
                    break;
                case "right":
                    nextPositon[1] = (player[1] + 1 < matrix.GetLength(0)) ? player[1] + 1 : 0;
                    nextPositon[0] = player[0];
                    break;
                case "left":
                    nextPositon[1] = (player[1] - 1 >= 0) ? player[1] - 1 : matrix.GetLength(0) - 1;
                    nextPositon[0] = player[0];
                    break;
                case "up":
                    nextPositon[0] = (player[0] - 1 >= 0) ? player[0] - 1 : matrix.GetLength(0) - 1;
                    nextPositon[1] = player[1];
                    break;
            }

            if (matrix[nextPositon[0]][nextPositon[1]] != otherPlayerSymbol)
            {
                matrix[nextPositon[0]][nextPositon[1]] = playerSymbol;
            }
            else
            {
                matrix[nextPositon[0]][nextPositon[1]] = 'x';
                return false;
            }

            player[0] = nextPositon[0];
            player[1] = nextPositon[1];

            return true;
        }
    }
}
