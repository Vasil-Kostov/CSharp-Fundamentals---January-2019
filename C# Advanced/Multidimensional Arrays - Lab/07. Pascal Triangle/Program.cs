namespace _07._Pascal_Triangle
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            
            long[][] jaggedArr = new long[n][];

            jaggedArr[0] = new long[1];
            jaggedArr[0][0] = 1;

            for (int i = 1; i < n; i++)
            {
                jaggedArr[i] = new long[i + 1];
                jaggedArr[i][0] = 1;
                jaggedArr[i][i] = 1;

                for (int j = 1; j < i; j++)
                {
                    jaggedArr[i][j] = jaggedArr[i - 1][j - 1] + jaggedArr[i - 1][j];
                }
            }

            foreach (var row in jaggedArr)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
