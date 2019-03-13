namespace MilitaryElite.Models.Soldiers.Privates.SpetialisedSoldiers
{
    using Interfaces.Soldiers.Private.SpecialisedSoldiers;
    using System.Collections.Generic;
    using System.Text;

    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstname, string lastName
            , decimal salary, string corps, List<Mission> missions)
            : base(id, firstname, lastName, salary, corps)
        {
            this.Misions = missions.AsReadOnly();
        }

        public IReadOnlyList<Mission> Misions { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Missions:");

            foreach (var mission in this.Misions)
            {
                sb.AppendLine(mission.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
