namespace MilitaryElite.Models
{
    using Interfaces;

    public class Soldier : ISoldier
    {
        public Soldier(string id, string firstname, string lastName)
        {
            this.Id = id;
            this.FirstName = firstname;
            this.LastName = lastName;
        }

        public string Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
