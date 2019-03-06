namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Patient
    {
        public Patient(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int Room { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
