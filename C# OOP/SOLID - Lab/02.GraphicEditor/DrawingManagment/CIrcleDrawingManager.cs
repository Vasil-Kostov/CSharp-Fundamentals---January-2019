namespace _02.GraphicEditor.DrawingManagment
{
    using Contracts;
    using System;

    public class CIrcleDrawingManager : DrawingManager
    {
        protected override void DrawFigure(IShape shape)
        {
            Circle circle = (Circle)shape ;

            Console.WriteLine("I'm Circle");
        }
    }
}
