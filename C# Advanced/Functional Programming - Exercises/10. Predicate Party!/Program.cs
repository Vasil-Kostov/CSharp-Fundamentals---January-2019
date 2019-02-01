namespace _10._Predicate_Party_
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Func<string, string, string, bool> prediacate = (guest, criterion, compareTo) => criterion == "EndsWith" ?
                                                            guest.EndsWith(compareTo) : criterion == "StartsWith" ?
                                                            guest.StartsWith(compareTo) : guest.Length == int.Parse(compareTo);

            var guests = Console.ReadLine().Split().ToList();

            string[] commandArr = Console.ReadLine().Split();

            while (commandArr[0] != "Party!")
            {
                string command = commandArr[0];
                string criterion = commandArr[1];
                string compareTo = commandArr[2];

                if (command == "Remove")
                {
                    guests = guests.Where(g => !prediacate(g, criterion, compareTo)).ToList();
                }
                else if (command == "Double")
                {
                    var doubleThisGuests = guests.Where(g => prediacate(g, criterion, compareTo)).ToList();

                    foreach (var guest in doubleThisGuests)
                    {
                        int index = guests.IndexOf(guest) + 1;

                        guests.Insert(index, guest);
                    }
                }

                commandArr = Console.ReadLine().Split();
            }

            Console.WriteLine(guests.Any() ? $"{string.Join(", ", guests)} are going to the party!" 
                                           : "Nobody is going to the party!");
        }
    }
}
