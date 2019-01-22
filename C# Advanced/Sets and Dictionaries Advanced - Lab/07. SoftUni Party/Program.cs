namespace _07._SoftUni_Party
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            HashSet<string> VIPGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                char firstChar = input[0];

                if (input.Length == 8 && char.IsDigit(firstChar))
                {
                    VIPGuests.Add(input);
                }
                else if (input.Length == 8)
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (VIPGuests.Contains(input))
                {
                    VIPGuests.Remove(input);
                }
                else
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(VIPGuests.Count + regularGuests.Count);

            if (VIPGuests.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, VIPGuests));
            }

            if (regularGuests.Any())
            {
                Console.WriteLine(string.Join(Environment.NewLine, regularGuests));
            }
        }
    }
}
