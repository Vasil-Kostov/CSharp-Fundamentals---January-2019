namespace MilitaryElite
{
    using Interfaces;
    using Models.Soldiers.Privates.SpetialisedSoldiers;
    using Models.Soldiers.Privates;
    using Models.Soldiers;
    using Models;

    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static List<ISoldier> soldiers = new List<ISoldier>();

        public static void Main()
        {

            string line = Console.ReadLine();

            while (line != "End")
            {
                string[] soldierArgs = line.Split();
                string type = soldierArgs[0];
                string id = soldierArgs[1];
                string firsName = soldierArgs[2];
                string lastName = soldierArgs[3];

                switch (type)
                {
                    case "Private":
                        soldiers.Add(new Private(id, firsName, lastName, decimal.Parse(soldierArgs[4])));
                        break;
                    case "Spy":
                        soldiers.Add(new Spy(id, firsName, lastName, int.Parse(soldierArgs[4])));
                        break;
                    case "LieutenantGeneral":
                        string[] ids = soldierArgs.Skip(5).ToArray();

                        List<Private> privates = GetPrivates(ids);

                        soldiers.Add(new LieutenantGeneral(id, firsName, lastName
                            , decimal.Parse(soldierArgs[4]), privates));
                        break;
                    case "Engineer":
                        string[] repairsArgs = soldierArgs.Skip(6).ToArray();

                        List<Repair> repairs = GetRepairs(repairsArgs);

                        try
                        {
                            soldiers.Add(new Engineer(id, firsName, lastName, decimal.Parse(soldierArgs[4])
                                         , soldierArgs[5], repairs));

                        }
                        catch (ArgumentException)
                        {
                        }
                        break;
                    case "Commando":
                        string[] missiondsArgs = soldierArgs.Skip(6).ToArray();

                        List<Mission> missions = GetMissions(missiondsArgs);

                        soldiers.Add(new Commando(id, firsName, lastName, decimal.Parse(soldierArgs[4])
                                         , soldierArgs[5], missions));
                        break;
                }

                line = Console.ReadLine();
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier.ToString());
            }
        }

        private static List<Mission> GetMissions(string[] missiondsArgs)
        {
            List<Mission> missions = new List<Mission>();

            for (int i = 0; i < missiondsArgs.Length; i += 2)
            {
                try
                {
                    string codeName = missiondsArgs[i];
                    string state = missiondsArgs[i + 1];

                    missions.Add(new Mission(codeName, state));
                }
                catch (ArgumentException)
                {
                }
            }

            return missions;
        }

        private static List<Repair> GetRepairs(string[] repairsArgs)
        {
            List<Repair> repairs = new List<Repair>();

            for (int i = 0; i < repairsArgs.Length; i += 2)
            {
                string partName = repairsArgs[i];
                int hours = int.Parse(repairsArgs[i + 1]);

                repairs.Add(new Repair(partName, hours));
            }

            return repairs;
        }

        private static List<Private> GetPrivates(string[] ids)
        {
            List<Private> privates = new List<Private>();

            foreach (var id in ids)
            {
                if (soldiers.Where(s => s.GetType().Name == "Private").Any(s => s.Id == id))
                {
                    privates.Add((Private)soldiers.Find(s => s.GetType().Name == "Private" && s.Id == id));
                }
            }

            return privates;
        }
    }
}
