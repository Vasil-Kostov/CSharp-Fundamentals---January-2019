namespace MilitaryElite.Models
{
    using MilitaryElite.Interfaces;
    using System;

    public class Mission : IMission
    {
        private string state;

        public Mission(string codeName, string missionState)
        {
            this.CodeName = codeName;
            this.State = missionState;
        }

        public string CodeName { get; private set; }

        public string State
        {
            get => this.state;

            private set
            {
                if (value != "inProgress" && value != "Finished")
                {
                    throw new ArgumentException("invalid mission state");
                }

                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
