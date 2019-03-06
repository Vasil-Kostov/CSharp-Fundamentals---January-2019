namespace P07_FamilyTree
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Person
    {
        private string name;
        private string dateOfBirth;
        private List<Person> parents;
        private List<Person> children;

        public Person(string name, string dateOfBirth)
        {
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Parents = new List<Person>();
            this.Children = new List<Person>();
        }

        public List<Person> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public List<Person> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public override string ToString()
        {
            StringBuilder personInfo = new StringBuilder();

            personInfo.AppendLine($"{this.Name} {this.DateOfBirth}");

            personInfo.AppendLine($"Parents:");
            if (this.Parents.Any()) Parents.ForEach(p => personInfo.AppendLine($"{p.Name} {p.DateOfBirth}"));

            personInfo.AppendLine($"Children:");
            if (this.Children.Any()) Children.ForEach(c => personInfo.AppendLine($"{c.Name} {c.DateOfBirth}"));

            return personInfo.ToString().Trim();
        }
    }
}