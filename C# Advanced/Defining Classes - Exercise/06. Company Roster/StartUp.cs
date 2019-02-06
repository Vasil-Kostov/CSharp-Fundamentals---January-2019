namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<Department> departements = new List<Department>();

            int numberOfEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEmployees; i++)
            {
                string[] inputArr = Console.ReadLine().Split();

                if (!departements.Any(d => d.Name == inputArr[3]))
                {
                    departements.Add(new Department(inputArr[3]));
                }

                Employee currentEmp = null;

                if (inputArr.Length == 4)
                {
                    currentEmp = new Employee(inputArr[0], decimal.Parse(inputArr[1]), inputArr[2], departements.Find(d => d.Name == inputArr[3]));
                }
                else if (inputArr.Length == 5)
                {
                    if (int.TryParse(inputArr[4], out int age))
                    {
                        currentEmp = new Employee(inputArr[0], decimal.Parse(inputArr[1]), inputArr[2], departements.Find(d => d.Name == inputArr[3]), age);
                    }
                    else
                    {
                        currentEmp = new Employee(inputArr[0], decimal.Parse(inputArr[1]), inputArr[2], departements.Find(d => d.Name == inputArr[3]), inputArr[4]);
                    }
                }
                else
                {
                    currentEmp = new Employee(inputArr[0], decimal.Parse(inputArr[1]), inputArr[2], departements.Find(d => d.Name == inputArr[3]), inputArr[4], int.Parse(inputArr[5]));
                }

                departements.Find(d => d.Name == inputArr[3]).Employees.Add(currentEmp);
            }

            Department highestAvgSalaryDep = departements.OrderByDescending(d => d.GetAverageSalary()).First();

            Console.WriteLine($"Highest Average Salary: {highestAvgSalaryDep.Name}");

            foreach (var emp in highestAvgSalaryDep.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{emp.Name} {emp.Salary:F2} {emp.Email} {emp.Age}");
            }
        }
    }
}
