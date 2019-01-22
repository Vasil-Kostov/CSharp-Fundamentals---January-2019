namespace _09._Simple_Text_Editor
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Stack<string> states = new Stack<string>();
            StringBuilder sb = new StringBuilder();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "1":
                        states.Push(sb.ToString());
                        sb.Append(command[1]);
                        break;
                    case "2":
                        states.Push(sb.ToString());
                        sb.Remove(sb.Length - int.Parse(command[1]), int.Parse(command[1]));
                        break;
                    case "3":
                        Console.WriteLine(sb[int.Parse(command[1]) - 1]);
                        break;
                    case "4":
                        sb.Clear();
                        sb.Append(states.Pop());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
