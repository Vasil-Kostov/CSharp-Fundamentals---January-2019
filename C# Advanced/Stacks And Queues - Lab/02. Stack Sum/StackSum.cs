namespace _02._Stack_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StackSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<string> numbers = new Stack<string>(input.Split());

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "add")
                {
                    numbers.Push(tokens[1]);
                    numbers.Push(tokens[2]);
                }
                else if (tokens[0] == "remove")
                {
                    int numbersToRemove = int.Parse(tokens[1]);

                    if (numbers.Count >= numbersToRemove)
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            int sum = 0;

            foreach (var num in numbers)
            {
                sum += int.Parse(num);
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
