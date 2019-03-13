namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Circle : IDrawable
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Radius => this.radius;

        public string Draw()
        {
            StringBuilder circle = new StringBuilder();

            double rIn = this.radius - 0.4;

            double rOut = this.radius + 0.4;

            for (double y = this.radius; y >= -this.radius; --y)
            {

                for (double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;

                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        circle.Append("*");
                    }
                    else
                    {
                        circle.Append(" ");
                    }
                }

                circle.AppendLine();
            }

            return circle.ToString().TrimEnd();
        }
    }
}
