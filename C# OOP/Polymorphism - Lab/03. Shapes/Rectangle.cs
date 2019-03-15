namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double length, double height)
        {
            this.width = length;
            this.height = height;            
        }
        
        public override double CalculateArea()
        {
            return this.width * this.height;
        }

        public override double CalculatePerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
