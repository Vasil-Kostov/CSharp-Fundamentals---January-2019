namespace VehiclesExtension
{
    public class Bus : Vehicle
    {
        private double fuelCosnumptionWhenEmpy;

        public Bus(double fuelQuantity, double fuelConsumtion, double tankCapacity)
            : base(fuelQuantity, fuelConsumtion, tankCapacity)
        {
            this.fuelCosnumptionWhenEmpy = fuelConsumtion;
        }

        public string Drive(double km, string condition)
        {
            if (condition.EndsWith("Empty"))
            {
                this.fuelConsumption = fuelCosnumptionWhenEmpy;
                return base.Drive(km);
            }
            else
            {
                this.fuelConsumption = this.fuelCosnumptionWhenEmpy + 1.4;
                return base.Drive(km);
            }
        }
    }
}
