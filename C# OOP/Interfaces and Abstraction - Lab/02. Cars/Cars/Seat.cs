﻿namespace Cars
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }

        public string Model { get; }

        public string Color { get; }

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
            return $"{this.Color} {this.Model}{Environment.NewLine}" +
                $"{this.Start()}{Environment.NewLine}" +
                $"{this.Stop()}";
        }
    }
}
