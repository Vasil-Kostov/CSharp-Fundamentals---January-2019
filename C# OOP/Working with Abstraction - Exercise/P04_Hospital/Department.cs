namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Department
    {
        public Department(string name)
        {
            this.Name = name;
            this.Patients = new List<Patient>(20);
        }

        public string Name { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
