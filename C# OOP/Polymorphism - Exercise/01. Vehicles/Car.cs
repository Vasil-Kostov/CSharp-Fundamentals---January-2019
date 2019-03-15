namespace Vehicles
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumtion) 
            : base(fuelQuantity, fuelConsumtion + 0.9)
        {
        }
    }
}
