namespace MilitaryElite.Models.Soldiers.Privates
{
    using Interfaces.Soldiers.Private;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstname, string lastName
            , decimal salary, List<Private> privates)
            : base(id, firstname, lastName, salary)
        {
            this.Privates = privates;
        }

        public IReadOnlyList<Private> Privates { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{base.ToString()}");
            sb.AppendLine("Privates:");
            foreach (var privateObj in this.Privates)
            {
                sb.AppendLine("  " + privateObj.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
