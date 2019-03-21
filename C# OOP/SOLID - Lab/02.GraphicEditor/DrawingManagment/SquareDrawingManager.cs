namespace _02.GraphicEditor.DrawingManagment
{
    using Contracts;
    using System;

    public class SquareDrawingManager : DrawingManager
    {
        protected override void DrawFigure(IShape shape)
        {
            Square square = (Square)shape;

            Console.WriteLine("I'm Square");
        }
    }
}
