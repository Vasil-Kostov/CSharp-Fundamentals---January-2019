namespace _02._Point_in_Rectangle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public bool ContainsPoint(Point point)
        {
            return point.X >= this.topLeft.X && point.X <= this.bottomRight.X
                && point.Y <= this.topLeft.Y && point.Y >= this.bottomRight.Y;
        }
    }
}
