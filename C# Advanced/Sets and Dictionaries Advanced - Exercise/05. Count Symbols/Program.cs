namespace _05._Count_Symbols
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (!symbols.ContainsKey(symbol))
                {
                    symbols.Add(symbol, 0);
                }

                symbols[symbol]++;
            }

            foreach (var symbol in symbols)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
