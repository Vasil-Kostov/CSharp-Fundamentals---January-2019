using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            var departments = new List<Department>();
            var doctors = new List<Doctor>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] inputArgs = command.Split();
                var departamentName = inputArgs[0];
                var doctorsName = $"{inputArgs[1]} {inputArgs[2]}";

                var currentPatient = new Patient(inputArgs[3]);

                if (!doctors.Any(d => d.Name == doctorsName))
                {
                    doctors.Add(new Doctor(doctorsName));
                }

                if (!departments.Any(d => d.Name == departamentName))
                {
                    departments.Add(new Department(departamentName));
                }

                bool hasFreeBeds = departments.Find(d => d.Name == departamentName).Patients.Count() < 60;

                if (hasFreeBeds)
                {
                    doctors.Find(d => d.Name == doctorsName).Patients.Add(currentPatient);

                    currentPatient.Room = departments.Find(d => d.Name == departamentName).Patients.Count() / 3 + 1;
                    departments.Find(d => d.Name == departamentName).Patients.Add(currentPatient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] printArgs = command.Split();

                if (printArgs.Length == 1)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, departments.Find(d => d.Name == printArgs[0]).Patients));
                }
                else if (printArgs.Length == 2 && int.TryParse(printArgs[1], out int room))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, 
                        departments.Find(d => d.Name == printArgs[0])
                        .Patients.Where(p => p.Room == room)
                        .OrderBy(p => p.Name)));
                }
                else
                {
                    Console.WriteLine(string.Join(Environment.NewLine, 
                        doctors.Find(d => d.Name == command).Patients.OrderBy(p => p.Name)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
