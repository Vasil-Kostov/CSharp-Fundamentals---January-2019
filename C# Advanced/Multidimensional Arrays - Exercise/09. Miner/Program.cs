namespace _09._Miner
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> moves = new Queue<string>(Console.ReadLine().Split());

            char[,] matrix = new char[n, n];

            int coalsCount = 0;

            int[] currentIndex = new int[2];

            for (int i = 0; i < n; i++)
            {
                char[] row = Console.ReadLine().Split().Select(char.Parse).ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];

                    if (row[j] == 'c')
                    {
                        coalsCount++;
                    }
                    else if (row[j] == 's')
                    {
                        currentIndex[0] = i;
                        currentIndex[1] = j;
                        matrix[currentIndex[0], currentIndex[1]] = '*';
                    }
                }
            }

            while (moves.Any())
            {
                switch (moves.Dequeue())
                {
                    case "up":
                        if (currentIndex[0] > 0)
                        {
                            currentIndex[0] -= 1;
                        }
                        break;
                    case "right":
                        if (currentIndex[1] < n - 1)
                        {
                            currentIndex[1] += 1;
                        }
                        break;
                    case "left":
                        if (currentIndex[1] > 0)
                        {
                            currentIndex[1] -= 1;
                        }
                        break;
                    case "down":
                        if (currentIndex[0] < n - 1)
                        {
                            currentIndex[0] += 1;
                        }
                        break;
                    default:
                        break;
                }

                switch (matrix[currentIndex[0], currentIndex[1]])
                {
                    case 'c':
                        coalsCount--;
                        matrix[currentIndex[0], currentIndex[1]] = '*';

                        if (coalsCount == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({currentIndex[0]}, {currentIndex[1]})");
                            return;
                        }
                        break;
                    case 'e':
                        Console.WriteLine($"Game over! ({currentIndex[0]}, {currentIndex[1]})");
                        return;
                    default:
                        break;
                }
            }

            Console.WriteLine($"{coalsCount} coals left. ({currentIndex[0]}, {currentIndex[1]})");
        }
    }
}
