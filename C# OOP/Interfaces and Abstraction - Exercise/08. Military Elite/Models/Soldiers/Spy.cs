namespace MilitaryElite.Models.Soldiers
{
    using Interfaces.Soldiers;
    using System;

    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstname, string lastName, int codeNumber) 
            : base(id, firstname, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}" +
                $"Code Number: {this.CodeNumber}";
        }
    }
}
