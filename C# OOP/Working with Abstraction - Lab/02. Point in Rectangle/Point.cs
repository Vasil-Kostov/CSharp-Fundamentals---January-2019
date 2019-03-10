namespace _02._Point_in_Rectangle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; private set; }

        public double Y { get; private set; }
    }
}
