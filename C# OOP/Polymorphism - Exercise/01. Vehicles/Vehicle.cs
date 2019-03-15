namespace Vehicles
{
    public class Vehicle
    {
        protected double fuelQuantity;
        protected double fuelConsumption;

        public Vehicle(double fuelQuantity, double fuelConsumtion)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumtion;
        }

        public double FuelLef => this.fuelQuantity;

        public string Drive(double km)
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
            this.fuelQuantity += liters;
        }
    }
}
