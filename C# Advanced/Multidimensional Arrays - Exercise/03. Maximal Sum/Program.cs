namespace _03._Maximal_Sum
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[dimentions[0], dimentions[1]];

            for (int i = 0; i < dimentions[0]; i++)
            {
                int[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < dimentions[1]; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int maxSum = int.MinValue;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < dimentions[0] - 2; i++)
            {
                for (int j = 0; j < dimentions[1] - 2; j++)
                {
                    int currentsum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] 
                                  + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2] 
                                  + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currentsum > maxSum)
                    {
                        maxSum = currentsum;

                        sb.Clear();
                        sb.AppendLine($"{matrix[i, j]} { matrix[i, j + 1]} {matrix[i, j + 2]}");
                        sb.AppendLine($"{matrix[i + 1, j]} { matrix[i + 1, j + 1]} {matrix[i + 1, j + 2]}");
                        sb.Append($"{matrix[i + 2, j]} { matrix[i + 2, j + 1]} {matrix[i + 2, j + 2]}");
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            Console.WriteLine(sb);
        }
    }
}
