namespace MilitaryElite.Models.Soldiers.Privates.SpetialisedSoldiers
{
    using Interfaces.Soldiers.Private.SpecialisedSoldiers;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstname, string lastName
            , decimal salary, string corps, List<Repair> repairs) 
            : base(id, firstname, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public IReadOnlyList<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine(repair.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
