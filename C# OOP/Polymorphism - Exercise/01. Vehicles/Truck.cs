namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumtion) 
            : base(fuelQuantity, fuelConsumtion + 1.6)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters * 0.95);
        }
    }
}
