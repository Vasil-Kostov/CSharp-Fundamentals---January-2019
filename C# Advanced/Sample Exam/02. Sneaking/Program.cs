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

            //Sam may be killed befor the staert !!!

            string directions = Console.ReadLine();

            for (int i = 0; i < directions.Length; i++)
            {
                matricx = EnemyMoves(matricx);

                if (matricx[Sam[0]].Any(c => c == 'b'))
                {
                    int enemyIndex = 0;

                    for (int j = 0; j < matricx[Sam[0]].Length; j++)
                    {
                        if (matricx[Sam[0]][j] == 'b')
                        {
                            enemyIndex = j;
                            break;
                        }
                    }

                    if (enemyIndex < Sam[1])
                    {
                        Console.WriteLine($"Sam died at {Sam[0]}, {Sam[1]}");
                        matricx[Sam[0]][Sam[1]] = 'X';
                        break;
                    }
                }
                else if (matricx[Sam[0]].Any(c => c == 'd'))
                {
                    int enemyIndex = 0;

                    for (int j = 0; j < matricx[Sam[0]].Length; j++)
                    {
                        if (matricx[Sam[0]][j] == 'd')
                        {
                            enemyIndex = j;
                            break;
                        }
                    }

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
                    for (int i = 0; i < matricx[row].Length; i++)
                    {
                        if (matricx[row][i] == 'b')
                        {
                            if (i == matricx[row].Length - 1)
                            {
                                matricx[row][i] = 'd';
                            }
                            else
                            {
                                matricx[row][i] = '.';
                                matricx[row][i + 1] = 'b';
                            }

                            break;
                        }
                    }
                }
                else if (matricx[row].Any(c => c == 'd'))
                {
                    for (int i = 0; i < matricx[row].Length; i++)
                    {
                        if (matricx[row][i] == 'd')
                        {
                            if (i == 0)
                            {
                                matricx[row][i] = 'b';
                            }
                            else
                            {
                                matricx[row][i] = '.';
                                matricx[row][i - 1] = 'd';
                            }

                            break;
                        }
                    }
                }
            }

            return matricx;
        }
    }
}
