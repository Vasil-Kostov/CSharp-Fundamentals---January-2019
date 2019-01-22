namespace _04._Matrix_shuffling
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[dimentions[0], dimentions[1]];

            for (int i = 0; i < dimentions[0]; i++)
            {
                string[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < dimentions[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Count() == 5)
                {
                    int[] cells = command.Skip(1).Select(int.Parse).ToArray();

                    if (cells[0] >= 0 && cells[0] < dimentions[0] && cells[1] >= 0 && cells[1] < dimentions[1]
                        && cells[2] >= 0 && cells[2] < dimentions[0] && cells[3] >= 0 && cells[3] < dimentions[1])
                    {
                        string firstCell = matrix[cells[0], cells[1]];
                        matrix[cells[0], cells[1]] = matrix[cells[2], cells[3]];
                        matrix[cells[2], cells[3]] = firstCell;

                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                sb.Append(matrix[i, j] + " ");
                            }

                            if (i != matrix.GetLength(0) - 1)
                            {
                                sb.AppendLine();
                            }

                        }

                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
