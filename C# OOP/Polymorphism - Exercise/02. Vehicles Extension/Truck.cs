namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumtion, double tankCapacity) 
            : base(fuelQuantity, fuelConsumtion + 1.6, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.fuelQuantity -= liters * 0.05;
        }
    }
}
