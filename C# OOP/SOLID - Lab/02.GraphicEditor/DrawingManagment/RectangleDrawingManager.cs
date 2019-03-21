namespace _02.GraphicEditor.DrawingManagment
{
    using Contracts;
    using System;

    class RectangleDrawingManager : DrawingManager
    {
        protected override void DrawFigure(IShape shape)
        {
            Rectangle rectangle = (Rectangle)shape;

            Console.WriteLine("I'm Recangle");
        }
    }
}
