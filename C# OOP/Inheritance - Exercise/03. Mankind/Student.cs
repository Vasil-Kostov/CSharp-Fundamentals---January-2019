namespace _03._Mankind
{
    using System;
    using System.Linq;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            :base (firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;

            private set
            {
                if (!value.All(x => char.IsLetterOrDigit(x)) || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Faculty number: {this.FacultyNumber}";
        }
    }
}
