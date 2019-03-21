namespace _02.GraphicEditor.DrawingManagment
{
    using Contracts;

    public abstract class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            this.DrawFigure(shape);
        }

        protected abstract void DrawFigure(IShape shape);
    }
}
