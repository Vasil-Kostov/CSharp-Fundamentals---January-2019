namespace _06._Football_Team_Generator_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<Team> teams = new List<Team>();

            while (input != "END")
            {
                string[] args = input.Split(";");

                switch (args[0])
                {
                    case "Team":
                        string name = args[1];
                        try
                        {
                            Team team = new Team(name);
                            teams.Add(team);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Add":
                        string teamName = args[1];
                        try
                        {
                            if (!teams.Any(t => t.Name == teamName))
                            {
                                throw new ArgumentException($"Team {teamName} does not exist.");
                            }

                            Player player = new Player(args[2], int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]));

                            teams.FirstOrDefault(t => t.Name == teamName).AddPlayer(player);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Remove":
                        try
                        {
                            teams.Find(t => t.Name == args[1]).RemovePlayer(args[2]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Rating":
                        try
                        {
                            if (!teams.Any(t => t.Name == args[1]))
                            {
                                throw new ArgumentException($"Team {args[1]} does not exist.");
                            }

                            Team currentTeam = teams.FirstOrDefault(t => t.Name == args[1]);

                            Console.WriteLine($"{currentTeam.Name} - {currentTeam.Rating}");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
