namespace _05._Border_Control
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<IIdentifiable> passingers = new List<IIdentifiable>();

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] passingerInfo = line.Split();

                if (passingerInfo.Length == 3)
                {
                    passingers.Add(new Citizen(passingerInfo[0], int.Parse(passingerInfo[1]), passingerInfo[2]));
                }
                else if (passingerInfo.Length == 2)
                {
                    passingers.Add(new Robot(passingerInfo[0], passingerInfo[1]));
                }

                line = Console.ReadLine();
            }

            string faceIdsLastDigits = Console.ReadLine();

            passingers.Where(p => p.Id.EndsWith(faceIdsLastDigits))
                      .ToList()
                      .ForEach(p => Console.WriteLine(p.Id));
        }
    }
}
