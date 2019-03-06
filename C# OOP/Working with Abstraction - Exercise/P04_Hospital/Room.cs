namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Room
    {
        private int bedsAmount = 3;

        public Room()
        {
            this.Patients = new Patient[this.bedsAmount];
        }

        public Patient[] Patients { get; set; }
    }
}
