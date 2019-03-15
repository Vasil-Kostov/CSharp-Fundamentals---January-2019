using System;

namespace VehiclesExtension
{
    public class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;
        protected double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumtion, double tankCapacity)
        {
            this.tankCapacity = tankCapacity;
            this.fuelQuantity = fuelQuantity <= tankCapacity ? fuelQuantity : 0;
            this.fuelConsumption = fuelConsumtion;
        }

        public double FuelLef => this.fuelQuantity;

        public virtual string Drive(double km)
        {
            if (this.fuelQuantity >= this.fuelConsumption * km)
            {
                this.fuelQuantity -= this.fuelConsumption * km;

                return $"{this.GetType().Name} travelled {km} km";
            }
            else
            {
                return $"{this.GetType().Name} needs refueling";
            }
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (liters + this.fuelQuantity > this.tankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }

            this.fuelQuantity += liters;
        }
    }
}
