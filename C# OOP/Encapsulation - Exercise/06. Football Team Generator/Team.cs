namespace _06._Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating 
            => players.Count == 0 
            ? 0 
            : (this.players.Sum(p => p.SkillLevel) == 0
            ? 0
            : (int)Math.Round((this.players.Sum(p => p.SkillLevel) / (this.players.Count * 1.0))));

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.name} team.");
            }

            this.players.Remove(players.Find(p => p.Name == playerName));
        }
    }
}
