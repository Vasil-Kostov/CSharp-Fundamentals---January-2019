namespace _04.WorkForce
{
    using System;

    public delegate void JobFinishedEventHandler(Job job);

    public class Job
    {
        private string name;
        private int hoursOfWorkRequired;
        private Employee employee;

        public Job(string name, int hoursOfWorkRequired, Employee employee)
        {
            this.hoursOfWorkRequired = hoursOfWorkRequired;
            this.name = name;
            this.employee = employee;
        }

        public event JobFinishedEventHandler JobFinished;

        public void Update()
        {
            this.hoursOfWorkRequired -= this.employee.WorkHoursPerWeek;

            if (this.hoursOfWorkRequired <= 0)
            {
                Console.WriteLine($"Job {this.name} done!");
                this.JobFinished.Invoke(this);
            }
        }

        public override string ToString()
        {
            return $"Job: {this.name} Hours Remaining: {this.hoursOfWorkRequired}";
        }
    }
}
