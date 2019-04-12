namespace _04.WorkForce
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main(string[] args)
        {
            JobRepository jobs = new JobRepository();

            List<Employee> employees = new List<Employee>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                switch (command)
                {
                    case "Job":
                        string jobName = input[1];
                        int requiredHours = int.Parse(input[2]);
                        string employeeName = input[3];

                        Employee employee = employees.First(e => e.Name == employeeName);
                        Job job = new Job(jobName, requiredHours, employee);
                        jobs.AddJob(job);

                        break;

                    case "StandardEmployee":
                        employeeName = input[1];
                        employee = new StandardEmployee(employeeName);
                        employees.Add(employee);
                        break;

                    case "PartTimeEmployee":
                        employeeName = input[1];
                        employee = new PartTimeEmployee(employeeName);
                        employees.Add(employee);
                        break;

                    case "Pass":
                        jobs.ToList().ForEach(j => j.Update());

                        break;

                    case "Status":
                        foreach (var currentJob in jobs)
                        {
                            Console.WriteLine(currentJob);
                        }

                        break;

                    case "End":
                        return;
                }
            }
        }
    }
}
