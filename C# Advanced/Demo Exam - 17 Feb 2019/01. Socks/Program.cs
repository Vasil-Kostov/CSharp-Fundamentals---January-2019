namespace _01._Socks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Stack<int> leftSocks = new Stack<int>(Console.ReadLine()
                                                         .Split()
                                                         .Select(int.Parse));

            Queue<int> rightSocks = new Queue<int>(Console.ReadLine()
                                                          .Split()
                                                          .Select(int.Parse));

            List<int> sets = new List<int>();

            while (leftSocks.Any() && rightSocks.Any())
            {
                int leftSock = leftSocks.Peek();
                int rightSock = rightSocks.Peek();

                if (leftSock > rightSock)
                {
                    sets.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }
                else if (leftSock < rightSock)
                {
                    leftSocks.Pop();
                }
                else
                {
                    leftSocks.Push(leftSocks.Pop() + 1);
                    rightSocks.Dequeue();
                }
            }

            Console.WriteLine(sets.Max());
            Console.WriteLine(string.Join(" ", sets));
        }
    }
}
