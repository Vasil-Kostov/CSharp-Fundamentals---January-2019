namespace _02._Basic_Queue_Operations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Queue<int> NSX = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

            Queue<int> numbers = new Queue<int>();

            int[] input = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            int n = NSX.Dequeue();

            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(input[i]);
            }

            int s = NSX.Dequeue();

            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(NSX.Dequeue()))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = int.MaxValue;

                while (numbers.Count != 0)
                {
                    int num = numbers.Dequeue();

                    if (num < min)
                    {
                        min = num;
                    }
                }

                Console.WriteLine(min == int.MaxValue ? 0 : min);
            }
        }
    }
}
