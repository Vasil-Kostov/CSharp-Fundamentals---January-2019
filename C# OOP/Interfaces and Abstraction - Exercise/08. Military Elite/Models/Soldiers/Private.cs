namespace MilitaryElite.Models.Soldiers
{
    using MilitaryElite.Interfaces.Soldiers;

    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstname, string lastName, decimal salary) 
            : base(id, firstname, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()} Salary: {this.Salary:F2}";
        }
    }
}
