namespace _01._Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, int>> departmentPatientRoom = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split();

            while (input[0] != "Output")
            {
                string department = input[0];
                string doctor = $"{input[1]} {input[2]}";
                string patient = input[3];

                if (!departmentPatientRoom.ContainsKey(department))
                {
                    departmentPatientRoom.Add(department, new Dictionary<string, int>(60));
                }

                if (departmentPatientRoom[department].Count < 60)
                {
                    departmentPatientRoom[department].Add(patient, departmentPatientRoom[department].Count / 3 + 1);

                    if (!doctors.ContainsKey(doctor))
                    {
                        doctors.Add(doctor, new List<string>());
                    }

                    doctors[doctor].Add(patient);
                }

                input = Console.ReadLine().Split();
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                if (departmentPatientRoom.ContainsKey(command[0]))
                {
                    if (command.Length == 1)
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, departmentPatientRoom[command[0]].Keys));
                    }
                    else
                    {
                        foreach (var patinet in departmentPatientRoom[command[0]].Where(kvp => kvp.Value == int.Parse(command[1])).OrderBy(k => k.Key))
                        {
                            Console.WriteLine(patinet.Key);
                        }
                    }
                }
                else if (doctors.ContainsKey($"{command[0]} {command[1]}"))
                {
                    Console.WriteLine(string.Join(Environment.NewLine, doctors[$"{command[0]} {command[1]}"].OrderBy(p => p)));
                }

                command = Console.ReadLine().Split();
            }
        }
    }
}
