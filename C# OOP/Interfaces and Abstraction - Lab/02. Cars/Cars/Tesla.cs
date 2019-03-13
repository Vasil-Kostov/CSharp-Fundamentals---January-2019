namespace Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int bateries)
        {
            this.Model = model;
            this.Color = color;
            this.Bateries = bateries;
        }

        public string Model { get; }

        public string Color { get; }

        public int Bateries { get; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            return $"{this.Color} {this.Model} {this.Bateries} Batteries{Environment.NewLine}" +
                $"{this.Start()}{Environment.NewLine}" +
                $"{this.Stop()}";
        }
    }
}
