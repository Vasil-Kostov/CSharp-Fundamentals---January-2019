namespace VehiclesExtension
{
    class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumtion, double tankCapacity) 
            : base(fuelQuantity, fuelConsumtion + 0.9, tankCapacity)
        {
        }
    }
}
