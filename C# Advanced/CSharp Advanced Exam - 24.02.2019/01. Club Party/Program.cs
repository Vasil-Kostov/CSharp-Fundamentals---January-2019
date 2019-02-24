namespace _01._Club_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int hallsCapacity = int.Parse(Console.ReadLine());

            Stack<string> hallsAndReservations = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            Dictionary<string, List<int>> halls = new Dictionary<string, List<int>>();

            Queue<string> hallsNames = new Queue<string>();

            while (hallsAndReservations.Any())
            {
                string command = hallsAndReservations.Pop();

                if (char.IsLetter(command[0]))
                {
                    halls.Add(command, new List<int>());
                    hallsNames.Enqueue(command);
                }
                else if (hallsNames.Any())
                {
                    if (halls[hallsNames.Peek()].Sum() + int.Parse(command) <= hallsCapacity)
                    {
                        halls[hallsNames.Peek()].Add(int.Parse(command));
                    }
                    else
                    {
                        Console.WriteLine($"{hallsNames.Peek()} -> {string.Join(", ", halls[hallsNames.Peek()])}");
                        halls.Remove(hallsNames.Dequeue());
                        hallsAndReservations.Push(command);
                    }
                }
            }
        }
    }
}
