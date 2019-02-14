namespace _08.Threeuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var firstThreeple = new Threeuple<string, string, string>($"{firstLine[0]} {firstLine[1]}", firstLine[2], firstLine[3]);

            string[] secondLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            var secondThreeple = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), secondLine[2] == "drunk");

            string[] thirdLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var thirdThreeple = new Threeuple<string, double, string>(thirdLine[0], double.Parse(thirdLine[1]), thirdLine[2]);

            Console.WriteLine(firstThreeple);
            Console.WriteLine(secondThreeple);
            Console.WriteLine(thirdThreeple);
        }
    }
}
