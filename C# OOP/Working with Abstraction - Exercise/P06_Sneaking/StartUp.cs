namespace P06_Sneaking
{
    using System;
    using System.Linq;

    class StartUp
    {
        static char[][] room;
        static Player sam;
        static Player nik;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            room = new char[n][];

            FillTheRoom();

            FindPlayersCoordinates();

            var samsMoves = Console.ReadLine().ToCharArray();

            for (int i = 0; i < samsMoves.Length; i++)
            {
                EnemyMoves();

                if (IsSamDead())
                {
                    Console.WriteLine($"Sam died at {sam.CurrentRow}, {sam.CurrentCol}");
                    room[sam.CurrentRow][sam.CurrentCol] = 'X';
                    PrintRoom();
                    return;
                }

                room[sam.CurrentRow][sam.CurrentCol] = '.';

                switch (samsMoves[i])
                {
                    case 'U': sam.CurrentRow--; break;
                    case 'D': sam.CurrentRow++; break;
                    case 'L': sam.CurrentCol--; break;
                    case 'R': sam.CurrentCol++; break;
                    default:
                        break;
                }

                room[sam.CurrentRow][sam.CurrentCol] = 'S';

                if (sam.CurrentRow == nik.CurrentRow)
                {
                    Console.WriteLine("Nikoladze killed!");
                    room[nik.CurrentRow][nik.CurrentCol] = 'X';
                    PrintRoom();
                    return;
                }
            }
        }
        
        private static void PrintRoom()
        {
            foreach (var line in room)
            {
                Console.WriteLine(line);
            }
        }

        private static bool IsSamDead()
        {
            bool isDead = false;

            if (room[sam.CurrentRow].Contains('b'))
            {
                int enemyIndex = Array.IndexOf(room[sam.CurrentRow], 'b');

                if (enemyIndex < sam.CurrentCol)
                {
                    isDead = true;
                }
            }
            else if (room[sam.CurrentRow].Contains('d'))
            {
                int enemyIndex = Array.IndexOf(room[sam.CurrentRow], 'd');

                if (enemyIndex > sam.CurrentCol)
                {
                    isDead = true;
                }
            }

            return isDead;
        }

        private static void EnemyMoves()
        {
            for (int row = 0; row < room.GetLength(0); row++)
            {
                if (room[row].Contains('b'))
                {
                    int index = Array.IndexOf(room[row], 'b');

                    if (index == room[row].Length - 1)
                    {
                        room[row][index] = 'd';
                    }
                    else
                    {
                        room[row][index] = '.';
                        room[row][index + 1] = 'b';
                    }

                }
                else if (room[row].Contains('d'))
                {
                    int index = Array.IndexOf(room[row], 'd');

                    if (index == 0)
                    {
                        room[row][index] = 'b';
                    }
                    else
                    {
                        room[row][index] = '.';
                        room[row][index - 1] = 'd';
                    }
                }
            }
        }

        private static void FindPlayersCoordinates()
        {
            for (int row = 0; row < room.GetLength(0); row++)
            {
                if (room[row].Contains('S'))
                {
                    sam = new Player(row, Array.IndexOf(room[row], 'S'));
                }
                else if (room[row].Contains('N'))
                {
                    nik = new Player(row, Array.IndexOf(room[row], 'N'));
                }
            }
        }

        private static void FillTheRoom()
        {
            for (int row = 0; row < room.GetLength(0); row++)
            {
                room[row] = Console.ReadLine().ToCharArray();
            }
        }
    }
}
