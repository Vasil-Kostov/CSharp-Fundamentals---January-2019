namespace _02._Excel_Functions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            List<string>[] matrix = new List<string>[rows -1];

            List<string> header = Console.ReadLine().Split(", ").ToList();

            for (int i = 0; i < rows - 1; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ").ToList();
            }

            string[] command = Console.ReadLine().Split();

            switch (command[0])
            {
                case "hide":
                    int colToHide = header.IndexOf(command[1]);

                    header.RemoveAt(colToHide);

                    Console.WriteLine(string.Join(" | ", header));

                    for (int i = 0; i < rows - 1; i++)
                    {
                        matrix[i].RemoveAt(colToHide);

                        Console.WriteLine(string.Join(" | ", matrix[i]));
                    }
                    break;

                case "sort":
                    int sortIndex = header.IndexOf(command[1]);
                    Console.WriteLine(string.Join(" | ", header));

                    List<string> sortingList = new List<string>();
                    for (int i = 0; i < rows - 1; i++)
                    {
                        sortingList.Add(matrix[i][sortIndex]);
                    }

                    foreach (var sort in sortingList.OrderBy(x => x))
                    {
                        Console.WriteLine(string.Join(" | ", matrix.First(m => m[sortIndex] == sort)));
                    }

                    break;
                case "filter":
                    int filterIndex = header.IndexOf(command[1]);
                    Console.WriteLine(string.Join(" | ", header));

                    foreach (var row in matrix.Where(r => r[filterIndex] == command[2]))
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
