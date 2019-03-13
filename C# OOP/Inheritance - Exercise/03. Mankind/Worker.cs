namespace _03._Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstname, string lastName, decimal weekSalary, decimal workHoursPerDay)
            :base (firstname, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal SalaryPerHour => this.WeekSalary / (5 * this.WorkHoursPerDay);

        public decimal WeekSalary
        {
            get => this.weekSalary;

            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get => this.workHoursPerDay;

            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }

        public override string ToString()
        {
            StringBuilder printFormat = new StringBuilder();
            printFormat.AppendLine($"{base.ToString()}");
            printFormat.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            printFormat.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            printFormat.AppendLine($"Salary per hour: {this.SalaryPerHour:F2}");

            return printFormat.ToString().Trim();
        }
    }
}
