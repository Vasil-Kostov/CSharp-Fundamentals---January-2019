namespace BirthdayCelebrations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<IBirthable> list = new List<IBirthable>();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] args = line.Split();

                if (args[0] == "Citizen")
                {
                    DateTime birthdate = DateTime.ParseExact(args[4], "dd/MM/yyyy", null);

                    list.Add(new Citizen(args[1], int.Parse(args[2]), args[3], birthdate));
                }
                else if (args[0] == "Pet")
                {
                    DateTime birthdate = DateTime.ParseExact(args[2], "dd/MM/yyyy", null);

                    list.Add(new Pet(args[1], birthdate));
                }

                line = Console.ReadLine();
            }

            int year = int.Parse(Console.ReadLine());

            list.Where(x => x.Birthdate.Year == year)
                .ToList()
                .ForEach(x => Console.WriteLine(string.Format($"{x.Birthdate:dd/MM/yyy}")));
        }
    }
}
