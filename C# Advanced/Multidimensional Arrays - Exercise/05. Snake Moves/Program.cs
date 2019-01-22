namespace _05._Snake_Moves
{
    using System;
    using System.Linq;
    using System.Text;

    class Program
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            char[,] matrix = new char[dimentions[0], dimentions[1]];

            string word = Console.ReadLine();

            int index = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = word[index % word.Length];

                    index++;
                }
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sb.Append(matrix[i, j]);
                }

                if (i != matrix.GetLength(0) - 1)
                {
                    sb.AppendLine();
                }
            }

            Console.WriteLine(sb);
            
        }
    }
}
