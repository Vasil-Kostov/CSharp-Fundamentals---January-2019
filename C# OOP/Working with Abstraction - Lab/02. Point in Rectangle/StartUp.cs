namespace _02._Point_in_Rectangle
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] rectangleCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point topLeft = new Point(rectangleCoordinates[0], rectangleCoordinates[1]);
            Point bottomRight = new Point(rectangleCoordinates[2], rectangleCoordinates[3]);

            Rectangle rectangle = new Rectangle(topLeft, bottomRight);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double[] pointCoordinates = Console.ReadLine().Split().Select(double.Parse).ToArray();

                Console.WriteLine(rectangle.ContainsPoint(new Point(pointCoordinates[0], pointCoordinates[1])));
            }
        }
    }
}
