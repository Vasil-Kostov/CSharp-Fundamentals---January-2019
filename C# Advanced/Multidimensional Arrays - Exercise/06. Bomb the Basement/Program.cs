namespace _06._Bomb_the_Basement
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

            int[] bombParameters = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int minusElements = 0;


            for (int i = 0; i < bombParameters[2] * 2 + 1; i++)
            {
                if (i > 0)
                {
                    minusElements = 1 + i / 3;
                }

                for (int j = bombParameters[1] - bombParameters[2] + minusElements; j <= bombParameters[1] + bombParameters[2] - minusElements; j++)
                {
                    if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
                    {
                        matrix[i, j] = 1;
                    }
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
