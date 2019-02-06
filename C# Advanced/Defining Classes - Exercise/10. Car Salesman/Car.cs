namespace DefiningClasses
{
    using System;
    using System.Text;

    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine, int? weight, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = weight;
            this.Color = color;
        }

        public Car(string model, Engine engine, int? weight) : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, null, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, null, "n/a")
        {
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int? Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public override string ToString()
        {
            string engineDisDisplacement = this.Engine.Displacement != null ? this.Engine.Displacement.ToString() : "n/a";
            string carWeight = this.Weight != null ? this.Weight.ToString() : "n/a";

            StringBuilder output = new StringBuilder();

            output.AppendLine($"{this.model}:");
            output.AppendLine($"  {this.Engine.Model}:");
            output.AppendLine($"    Power: {this.Engine.Power}");
            output.AppendLine($"    Displacement: {engineDisDisplacement}");
            output.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
            output.AppendLine($"  Weight: {carWeight}");
            output.Append($"  Color: {this.Color}");

            return output.ToString();
        }

    }
}
