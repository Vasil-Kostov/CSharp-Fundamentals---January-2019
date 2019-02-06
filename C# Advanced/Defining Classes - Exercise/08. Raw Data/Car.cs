namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tireSet;

        public Car(string[] carInfo)
        {
            this.Model = carInfo[0];

            this.Engine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));

            this.Cargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);

            this.TireSet = new Tire[4]
            {
                new Tire(double.Parse(carInfo[5]), int.Parse(carInfo[6])),
                new Tire(double.Parse(carInfo[7]), int.Parse(carInfo[8])),
                new Tire(double.Parse(carInfo[9]), int.Parse(carInfo[10])),
                new Tire(double.Parse(carInfo[11]), int.Parse(carInfo[12]))
            };
        }

        public Tire[] TireSet
        {
            get { return this.tireSet; }
            set { this.tireSet = value; }
        }
        
        public Cargo Cargo
        {
            get { return this.cargo; }
            set { this.cargo = value; }
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
    }
}
