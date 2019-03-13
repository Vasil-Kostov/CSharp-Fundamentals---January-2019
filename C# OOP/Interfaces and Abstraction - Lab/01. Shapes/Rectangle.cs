namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public string Draw()
        {
            StringBuilder rectangle = new StringBuilder();

            rectangle.AppendLine(Line(this.width, '*', '*'));

            for (int i = 1; i < this.height - 1; ++i)
            {
                rectangle.AppendLine(Line(this.width, '*', ' '));
            }

            rectangle.AppendLine(Line(this.width, '*', '*'));

            return rectangle.ToString().TrimEnd();
        }

        private string Line(int width, char side, char mid)
        {
            return $"{side}{new string(mid, width - 2)}{side}";
        }
    }
}
