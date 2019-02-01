namespace _05._Applied_Arithmetics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<int, int> multiplyFunc = x => x * 2;
            Func<int, int> addFunc = x => x + 1;
            Func<int, int> subtract = x => x - 1;

            Action<List<int>> printAction = x => Console.WriteLine(string.Join(" ", x));

            List<int> nums = Console.ReadLine()
                             .Split()
                             .Select(int.Parse)
                             .ToList();

            while (true)
            {
                string command;

                switch (command = Console.ReadLine())
                {
                    case "add":
                        nums = nums.Select(x => addFunc(x)).ToList();
                        break;
                    case "subtract":
                        nums = nums.Select(x => subtract(x)).ToList();
                        break;
                    case "multiply":
                        nums = nums.Select(x => multiplyFunc(x)).ToList();
                        break;
                    case "print":
                        printAction(nums);
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
