namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int numberOfInbuts = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < numberOfInbuts; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                switch (input[0])
                {
                    case 1:
                        numbers.Push(input[1]);
                        break;
                    case 2:
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.ToArray().Max());
                        }
                        break;
                    case 4:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.ToArray().Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
