namespace _01._Class_Box
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Box
    {
        private decimal length;
        private decimal width;
        private decimal height;

        public Box(decimal length, decimal width, decimal height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public decimal GetSurfaceArea()
        {
            return this.width * this.length * 2 + this.GetLateralSurfaceArea();
        }

        public decimal GetLateralSurfaceArea()
        {
            return this.length * this.height * 2 + this.width * this.height * 2;
        }

        public decimal GetVolume()
        {
            return this.length * this.width * this.height;
        }
    }
}
