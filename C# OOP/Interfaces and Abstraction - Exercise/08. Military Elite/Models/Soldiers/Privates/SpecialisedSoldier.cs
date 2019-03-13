namespace MilitaryElite.Models.Soldiers.Privates
{
    using Interfaces.Soldiers.Private;
    using System;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(string id, string firstname, string lastName
            , decimal salary, string corps) 
            : base(id, firstname, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;

            private set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid corps");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.corps}"; 
        }
    }
}
