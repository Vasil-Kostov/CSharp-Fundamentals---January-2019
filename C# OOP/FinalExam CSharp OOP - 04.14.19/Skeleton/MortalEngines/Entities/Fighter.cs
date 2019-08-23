namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;

    public class Fighter : BaseMachine, IFighter
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints)
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleAggressiveMode();
        }
                
        public bool AggressiveMode { get; private set; }

        public void ToggleAggressiveMode()
        {
            this.AggressiveMode = !this.AggressiveMode;

            if (AggressiveMode)
            {
                this.AttackPoints += 50;
                this.DefensePoints -= 25;
            }
            else
            {
                this.AttackPoints -= 50;
                this.DefensePoints += 25;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            string agresive = this.AggressiveMode ? "ON" : "OFF";

            result += Environment.NewLine + ($" *Aggressive: {agresive}");

            return result;
        }
    }
}
