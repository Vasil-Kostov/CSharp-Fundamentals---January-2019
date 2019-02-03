namespace CarManufacturer
{
    public class Engine
    {
        private int horsePowers;
        private double cubicCapacity;
   
        public Engine(int horsePowers, double cubicCapacity)
        {
            this.HorsePowers = horsePowers;
            this.CubicCapacity = cubicCapacity;
        }
   
        public int HorsePowers
        {
            get { return this.horsePowers; }
            set { this.horsePowers = value; }
        }
        
        public double CubicCapacity
        {
            get { return this.cubicCapacity; }
            set { this.cubicCapacity = value; }
        }
    }
}
