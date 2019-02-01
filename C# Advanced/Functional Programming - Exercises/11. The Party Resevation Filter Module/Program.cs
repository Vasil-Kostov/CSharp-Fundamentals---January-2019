namespace _11._The_Party_Resevation_Filter_Module
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string, string, string, bool> filter = (name, criterion, compareTo) =>
                                                          criterion == "Starts with" ? !name.StartsWith(compareTo)
                                                        : criterion == "Ends with" ? !name.EndsWith(compareTo)
                                                        : criterion == "Length" ? name.Length != int.Parse(compareTo)
                                                        : !name.Contains(compareTo);

            var names = Console.ReadLine().Split().ToList();

            var filtersAsStr = new List<string>();

            string[] command = Console.ReadLine().Split(';');

            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    filtersAsStr.Add($"{command[1]};{command[2]}");
                }
                else
                {
                    filtersAsStr.Remove($"{command[1]};{command[2]}");
                }

                command = Console.ReadLine().Split(';');
            }

            foreach (var item in filtersAsStr)
            {
                string criteria = item.Split(';').First();
                string compareTo = item.Split(';').Last();

                names = names.Where(n => filter(n, criteria, compareTo)).ToList();
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
