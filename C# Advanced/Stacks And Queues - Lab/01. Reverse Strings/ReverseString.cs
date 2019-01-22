namespace _01._Reverse_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseStrings
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<char> result = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                result.Push(input[i]);
            }

            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }

            Console.WriteLine();
        }
    }
}
