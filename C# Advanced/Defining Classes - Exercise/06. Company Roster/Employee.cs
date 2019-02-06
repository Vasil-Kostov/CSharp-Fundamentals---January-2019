namespace DefiningClasses
{
    public class Employee
    {
        private string name;
        private Department department;
        private decimal salary;
        private string position;
        private string email;
        private int age;

        public Employee(string name, decimal salary, string position, Department department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, decimal salary, string position, Department department, string email) 
            : this(name, salary, position, department, email, -1)
        {
        }

        public Employee(string name, decimal salary, string position, Department department, int age)
            : this(name, salary, position, department, "n/a", age)
        {
        }

        public Employee(string name, decimal salary, string position, Department department)
            : this(name, salary, position, department, "n/a", -1)
        {
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
