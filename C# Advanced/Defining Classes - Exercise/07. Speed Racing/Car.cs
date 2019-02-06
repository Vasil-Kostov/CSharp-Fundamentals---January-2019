using System;

namespace DefinintgClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKM;
        private int traveledKM;

        public int TtraveledKM
        {
            get { return this.traveledKM; }
            private set { this.traveledKM = value; }
        }



        public Car(string model, double fuelAmount, double fuelConsumptionPerKM)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKM = fuelConsumptionPerKM;
        }

        public double FuelConsumptionPerKM
        {
            get { return this.fuelConsumptionPerKM; }
            set { this.fuelConsumptionPerKM = value; }
        }

        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public void Drive(int KM)
        {
            if (this.FuelAmount >= (KM * this.FuelConsumptionPerKM))
            {
                this.FuelAmount -= KM * this.FuelConsumptionPerKM;
                this.TtraveledKM += KM;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
