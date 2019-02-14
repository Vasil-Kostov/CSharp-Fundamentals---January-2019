namespace _03._Stack
{
    using CustomStack;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            CustomSack<string> stack = new CustomSack<string>();

            string[] command = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Push": stack.Push(command.Skip(1).ToArray()); break;

                    case "Pop":
                        try
                        {
                            stack.Pop();
                        }
                        catch (Exception exept)
                        {
                            Console.WriteLine(exept.Message);
                        }

                        break;
                }

                command = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var element in stack)
                {
                    Console.WriteLine(element);
                }
            }
        }
    }
}
