namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            Stack<char> brackets = new Stack<char>();

            string input = Console.ReadLine();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    brackets.Push(input[i]);
                }
                else
                {
                    if (brackets.Any())
                    {
                        if (input[i] == '}')
                        {
                            if (brackets.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else if (input[i] == ')')
                        {
                            if (brackets.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                        else
                        {
                            if (brackets.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            Console.WriteLine("YES");
           
        }
    }
}
