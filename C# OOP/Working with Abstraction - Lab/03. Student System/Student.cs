namespace P03_StudentSystem
{
    public class Student
    {
        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public double Grade { get; private set; }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public override string ToString()
        {
            string printFormat = $"{this.Name} is {this.Age} years old.";

            if (this.Grade >= 5.00)
            {
                printFormat += " Excellent student.";
            }
            else if (this.Grade < 5.00 && this.Grade >= 3.50)
            {
                printFormat += " Average student.";
            }
            else
            {
                printFormat += " Very nice person.";
            }

            return printFormat;
        }
    }
}