namespace _07._The_V_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, int[]> vloggerWithStatistics = new Dictionary<string, int[]>();
            Dictionary<string, List<string>> vloggerWithFollowers = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string firstVlogger = input.Split(" ").First();

                if (input.Contains("joined"))
                {
                    if (!vloggerWithStatistics.ContainsKey(firstVlogger))
                    {
                        vloggerWithStatistics.Add(firstVlogger, new int[2]);
                        vloggerWithFollowers.Add(firstVlogger, new List<string>());
                    }
                }
                else
                {
                    string secondVlogger = input.Split(" ").Last();

                    if (firstVlogger != secondVlogger)
                    {
                        if (vloggerWithStatistics.ContainsKey(secondVlogger) 
                            && vloggerWithStatistics.ContainsKey(firstVlogger) 
                            && !vloggerWithFollowers[secondVlogger].Contains(firstVlogger))
                        {
                            vloggerWithStatistics[firstVlogger][1]++;
                            vloggerWithStatistics[secondVlogger][0]++;
                            vloggerWithFollowers[secondVlogger].Add(firstVlogger);
                        }

                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggerWithStatistics.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in vloggerWithStatistics.OrderByDescending(v => v.Value[0]).ThenBy(v => v.Value[1]))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value[0]} followers, {vlogger.Value[1]} following");

                if (counter == 1)
                {
                    var topVlogger = vloggerWithFollowers.First(v => v.Key == vlogger.Key);

                    foreach (var follower in topVlogger.Value.OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                counter++;
            }
        }
    }
}
