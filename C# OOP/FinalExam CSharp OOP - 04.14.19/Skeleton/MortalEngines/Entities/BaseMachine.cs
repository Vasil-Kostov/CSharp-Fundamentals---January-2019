namespace MortalEngines.Entities
{
    using Contracts;

    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class BaseMachine : IMachine
    {
        private string name;
        private IPilot pilot;

        public BaseMachine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.Targets = new List<string>();
        }

        public string Name
        {
            get => this.name;

            private set
            {
                if (string.IsNullOrWhiteSpace(value)) //What if value is empty string
                {
                    throw new ArgumentNullException("Machine name cannot be null or empty.");
                }

                this.name = value;
            }
        }

        public IPilot Pilot
        {
            get => this.pilot;

            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("Pilot cannot be null.");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints { get; set; }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public IList<string> Targets { get; set; }

        public void Attack(IMachine target)
        {
            if (target == null)
            {
                throw new NullReferenceException("Target cannot be null");
            }

            double difference = this.AttackPoints - target.DefensePoints;

            if (difference > 0)
            {
                target.HealthPoints -= difference;
            }

            if (target.HealthPoints < 0)
            {
                target.HealthPoints = 0;
            }

            this.Targets.Add(target.Name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"- {this.Name}");
            sb.AppendLine($" *Type: {this.GetType().Name}");
            sb.AppendLine($" *Health: {this.HealthPoints:F2}");
            sb.AppendLine($" *Attack: {this.AttackPoints:F2}");
            sb.AppendLine($" *Defense: {this.DefensePoints:F2}");

            if (this.Targets.Count > 0)
            {
                sb.AppendLine($" *Targets: " + string.Join(", ", this.Targets));
            }
            else
            {
                sb.Append($" *Targets: None");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
