namespace CarManufacturer
{
    using System;
    using System.Text;
    
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;
    
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }
    
        public Car(string make, string model, int year)
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }
    
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }
    
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    
        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }
    
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
    
        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }
    
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }
    
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
    
        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }
    
        public Tire[] Tires
        {
            get { return this.tires; }
            set { this.tires = value; }
        }
        
        public void Drive(double distance)
        {
            if (FuelQuantity - ((distance / 100) * FuelConsumption) > 0)
            {
                FuelQuantity -= ((distance / 100) * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
    
        public string WhoAmI()
        {
            var result = new StringBuilder();
    
            result.AppendLine($"Make: {this.Make}");
            result.AppendLine($"Model: {this.Model}");
            result.AppendLine($"Year: {this.Year}");
            result.AppendLine($"HorsePowers: {this.Engine.HorsePowers}");
            result.Append($"FuelQuantity: {this.FuelQuantity}L");
    
            return result.ToString();
        }
    }
}
