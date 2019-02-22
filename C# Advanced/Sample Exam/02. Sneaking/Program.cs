namespace _02._Sneaking
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            int[] Nik = new int[2];
            int[] Sam = new int[2];

            char[][] matricx = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                string line = Console.ReadLine();

                if (line.Contains('N'))
                {
                    Nik[0] = i;
                    Nik[1] = line.IndexOf('N');
                }

                if (line.Contains('S'))
                {
                    Sam[0] = i;
                    Sam[1] = line.IndexOf('S');
                }

                matricx[i] = line.ToCharArray();
            }

            string directions = Console.ReadLine();

            for (int i = 0; i < directions.Length; i++)
            {
                matricx = EnemyMoves(matricx);

                if (matricx[Sam[0]].Any(c => c == 'b'))
                {
                    int enemyIndex = Array.IndexOf(matricx[Sam[0]], 'b');

                    if (enemyIndex < Sam[1])
                    {
                        Console.WriteLine($"Sam died at {Sam[0]}, {Sam[1]}");
                        matricx[Sam[0]][Sam[1]] = 'X';
                        break;
                    }
                }
                else if (matricx[Sam[0]].Any(c => c == 'd'))
                {
                    int enemyIndex = Array.IndexOf(matricx[Sam[0]], 'd');

                    if (enemyIndex > Sam[1])
                    {
                        Console.WriteLine($"Sam died at {Sam[0]}, {Sam[1]}");
                        matricx[Sam[0]][Sam[1]] = 'X';
                        break;
                    }
                }

                char SamsMove = directions[i];

                matricx[Sam[0]][Sam[1]] = '.';

                switch (SamsMove)
                {
                    case 'U': Sam[0]--; break;
                    case 'D': Sam[0]++; break;
                    case 'L': Sam[1]--; break;
                    case 'R': Sam[1]++; break;
                    default:
                        break;
                }

                matricx[Sam[0]][Sam[1]] = 'S';

                if (Sam[0] == Nik[0])
                {
                    Console.WriteLine("Nikoladze killed!");
                    matricx[Nik[0]][Nik[1]] = 'X';
                    break;
                }
            }

            foreach (var line in matricx)
            {
                Console.WriteLine(line);
            }
        }

        private static char[][] EnemyMoves(char[][] matricx)
        {

            for (int row = 0; row < matricx.GetLength(0); row++)
            {
                if (matricx[row].Any(c => c == 'b'))
                {
                    int index = Array.IndexOf(matricx[row], 'b');

                    if (index == matricx[row].Length - 1)
                    {
                        matricx[row][index] = 'd';
                    }
                    else
                    {
                        matricx[row][index] = '.';
                        matricx[row][index + 1] = 'b';
                    }

                }
                else if (matricx[row].Any(c => c == 'd'))
                {
                    int index = Array.IndexOf(matricx[row], 'd');

                    if (index == 0)
                    {
                        matricx[row][index] = 'b';
                    }
                    else
                    {
                        matricx[row][index] = '.';
                        matricx[row][index - 1] = 'd';
                    }
                }
            }

            return matricx;
        }
    }
}
