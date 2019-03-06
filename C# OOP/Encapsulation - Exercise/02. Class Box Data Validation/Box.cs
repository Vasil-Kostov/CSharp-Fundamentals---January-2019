namespace _02._Class_Box_Data_Validation
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
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        protected decimal Length
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        protected decimal Width
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        protected decimal Height
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
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
