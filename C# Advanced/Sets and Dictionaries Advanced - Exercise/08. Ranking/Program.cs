namespace _08._Ranking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, string> contestWithPass = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "end of contests")
            {
                if (input.Contains(':'))
                {
                    string[] contestInfo = input.Split(':');

                    contestWithPass[contestInfo[0]] = contestInfo[1];
                }

                input = Console.ReadLine();
            }

            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

            input = Console.ReadLine();

            while (input != "end of submissions")
            {
                string[] userInfo = input.Split("=>");

                string contest = userInfo[0];
                string pass = userInfo[1];
                string userName = userInfo[2];
                int userPoints = int.Parse(userInfo[3]);

                if (contestWithPass.ContainsKey(contest) && contestWithPass[contest].Equals(pass))
                {
                    if (!users.ContainsKey(userName))
                    {
                        users.Add(userName, new Dictionary<string, int>());
                    }

                    if (users[userName].ContainsKey(contest))
                    {
                        users[userName][contest] = Math.Max(users[userName][contest], userPoints);
                    }
                    else
                    {
                        users[userName][contest] = userPoints;
                    }
                }

                input = Console.ReadLine();
            }

            var bestCandidate = users.OrderByDescending(u => u.Value.Values.Sum()).First();

            Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestCandidate.Value.Values.Sum()} points.");

            Console.WriteLine("Ranking:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");

                foreach (var contest in user.Value.OrderByDescending(kvp => kvp.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
