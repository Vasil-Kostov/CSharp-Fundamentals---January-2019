﻿namespace P02_CarsSalesman
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Engine
    {
        private const string offset = "  ";

        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) 
            : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power) 
            :this(model, power, - 1, "n/a")
        {
        }

        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", offset, this.Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", offset, this.Power);
            sb.AppendFormat("{0}{0}Displacement: {1}\n", offset, this.Displacement == -1 ? "n/a" : this.Displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", offset, this.Efficiency);

            return sb.ToString();
        }
    }
}
