namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;

    public class Tank : BaseMachine, ITank
    {
        private const int InitialHealthPoints = 100;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InitialHealthPoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !DefenseMode;

            if (DefenseMode)
            {
                this.AttackPoints -= 40;
                this.DefensePoints += 30;
            }
            else
            {
                this.AttackPoints += 40;
                this.DefensePoints -= 30;
            }
        }

        public override string ToString()
        {
            string result = base.ToString();
            string defense = this.DefenseMode ? "ON" : "OFF";

            result += Environment.NewLine + $" *Defense: {defense}";

            return result;
        }
    }
}
