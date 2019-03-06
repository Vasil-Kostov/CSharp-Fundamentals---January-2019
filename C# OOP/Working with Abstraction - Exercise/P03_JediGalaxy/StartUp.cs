using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class StartUp
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .Select(int.Parse)
                               .ToArray();

            Galaxy galaxy = new Galaxy(dimestions);

            string command = Console.ReadLine();
            long ivosPower = 0;

            while (command != "Let the Force be with you")
            {
                Person ivo = new Person(command.Split( " ", StringSplitOptions.RemoveEmptyEntries)
                                               .Select(int.Parse)
                                               .ToArray());

                Person evil = new Person(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                           .Select(int.Parse)
                                                           .ToArray());

                EvilMoves(galaxy, evil);

                ivosPower += StarsGatheredByIvo(galaxy, ivo);

                command = Console.ReadLine();
            }

            Console.WriteLine(ivosPower);

        }

        private static long StarsGatheredByIvo(Galaxy galaxy, Person ivo)
        {
            long sum = 0;

            while (ivo.CurrentRow >= 0 && ivo.CurrentCol < galaxy.Matrix.GetLength(1))
            {
                if (galaxy.IsInTheGalaxy(ivo))
                {
                    sum += galaxy.Matrix[ivo.CurrentRow, ivo.CurrentCol];
                }

                ivo.CurrentRow--;
                ivo.CurrentCol++;
            }

            return sum;
        }

        private static void EvilMoves(Galaxy galaxy, Person evil)
        {
            while (evil.CurrentRow >= 0 && evil.CurrentCol >= 0)
            {
                if (galaxy.IsInTheGalaxy(evil))
                {
                    galaxy.Matrix[evil.CurrentRow, evil.CurrentCol] = 0;
                }

                evil.CurrentRow--;
                evil.CurrentCol--;
            }
        }

        private static void FillTheMatrix(int[,] matrix)
        {
            int value = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = value++;
                }
            }
        }
    }
}
