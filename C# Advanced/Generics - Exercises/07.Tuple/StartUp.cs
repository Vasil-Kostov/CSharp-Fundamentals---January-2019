namespace _07.Tuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split();

            Tuple<string, string> firstTuple = new Tuple<string, string>($"{firstLine[0]} {firstLine[1]}", firstLine[2]);

            string[] secondLine = Console.ReadLine().Split();

            Tuple<string, int> secondTuple = new Tuple<string, int>(secondLine[0], int.Parse(secondLine[1]));

            string[] thirdLine = Console.ReadLine().Split();

            Tuple<int, double> thirdTuple = new Tuple<int, double>(int.Parse(thirdLine[0]), double.Parse(thirdLine[1]));

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
