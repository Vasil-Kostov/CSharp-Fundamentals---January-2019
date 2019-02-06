namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;

    public class Tire
    {
        private double pessure;
        private int year;

        public Tire(double pressure, int year)
        {
            this.Pressure = pressure;
            this.Year = year;
        }

        public double Pressure
        {
            get { return this.pessure; }
            set { this.pessure = value; }
        }

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

    }
}
