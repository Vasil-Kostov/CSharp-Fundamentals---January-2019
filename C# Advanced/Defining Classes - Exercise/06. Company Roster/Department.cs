using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Department
    {
        private string name;

        public List<Employee> Employees { get; set; }

        public Department(string name)
        {
            this.Name = name;
            this.Employees = new List<Employee>();
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal GetAverageSalary()
        {
            decimal avgSalary = 0;

            foreach (var emp in Employees)
            {
                avgSalary += emp.Salary;
            }

            return avgSalary / Employees.Count;
        }
    }
}
