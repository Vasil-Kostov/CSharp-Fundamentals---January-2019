namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Doctor
    {
        public Doctor(string name)
        {
            this.Name = name;
            this.Patients = new List<Patient>();
        }

        public string Name { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
