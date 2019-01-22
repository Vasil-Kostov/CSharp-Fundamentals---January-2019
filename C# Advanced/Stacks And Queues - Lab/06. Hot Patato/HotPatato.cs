namespace _06._Hot_Potato
{
    using System;
    using System.Collections.Generic;

    class HotPatato
    {
        static void Main()
        {
            Queue<string> children = new Queue<string>(Console.ReadLine().Split());

            int n = int.Parse(Console.ReadLine());

            while (children.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    children.Enqueue(children.Dequeue());
                }

                Console.WriteLine($"Removed {children.Dequeue()}");
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
