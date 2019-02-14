namespace _01._ListyIterator
{
    using ListyIterator;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            ListyIterator<string> listyIterator = null;

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Create": listyIterator = new ListyIterator<string>(command.Skip(1).ToArray()); break;

                    case "Move": Console.WriteLine(listyIterator.Move()); break;

                    case "HasNext": Console.WriteLine(listyIterator.HasNext()); break;

                    case "Print": Console.WriteLine(listyIterator.Print()); break;
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
