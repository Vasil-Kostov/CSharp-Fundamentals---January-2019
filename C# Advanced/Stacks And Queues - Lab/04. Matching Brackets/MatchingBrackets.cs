namespace _04._Matching_Brackets
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MatchingBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> openingBrackets = new Stack<int>();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    openingBrackets.Push(i);
                }
                else if (input[i] == ')')
                {
                    int startIndex = openingBrackets.Pop();

                    sb.AppendLine(input.Substring(startIndex, i - startIndex + 1));
                }
            }

            Console.Write(sb);
        }
    }
}
