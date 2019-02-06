namespace DefiningClasses
{
    using System;

    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power, int? displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, null, efficiency)
        {
        }

        public Engine(string model, int power) : this(model, power, null, "n/a")
        {
        }

        public string Efficiency
        {
            get { return this.efficiency; }
            set { this.efficiency = value; }
        }

        public int? Displacement
        {
            get { return this.displacement; }
            set { this.displacement = value; }
        }

        public int Power
        {
            get { return this.power; }
            set { this.power = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

    }
}
