namespace _06._Football_Team_Generator
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main() // 80/100 
        {
            List<Team> teams = new List<Team>();

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] args = command.Split(";");

                try
                {
                    if (args[0] == "Team") 
                    {
                        teams.Add(new Team(args[1]));
                    }
                    else if (args[0] == "Add")
                    {
                        Player player = new Player(args[2], int.Parse(args[3]), int.Parse(args[4]), int.Parse(args[5]), int.Parse(args[6]), int.Parse(args[7]));

                        teams.Find(t => t.Name == args[1]).AddPlayer(player);
                    }
                    else if (args[0] == "Remove")
                    {
                        teams.Find(t => t.Name == args[1]).RemovePlayer(args[2]); 
                    }
                    else if (args[0] == "Rating")
                    {
                        Console.WriteLine($"{args[1]} - {teams.Find(t => t.Name == args[1]).Rating}");
                    }
                }
                catch (ArgumentException argEx)
                {
                    Console.WriteLine(argEx.Message);
                }
                catch (InvalidOperationException invOpEx)
                {
                    Console.WriteLine(invOpEx.Message);
                }
                catch (NullReferenceException) // It caches "object reference not set to an instance of an object", which is not tested in Judge
                {
                    Console.WriteLine($"Team {args[1]} does not exist.");
                }

                command = Console.ReadLine();
            }
        }
    }
}
