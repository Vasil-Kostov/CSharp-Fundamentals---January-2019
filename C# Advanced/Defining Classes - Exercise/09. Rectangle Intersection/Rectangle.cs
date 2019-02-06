namespace DefiningClasses
{
    class Rectangle
    {
        private string id;
        private double width;
        private double height;
        private double horizontal;
        private double vertical;

        public Rectangle(string id, double width, double height, double horizontal, double vertical)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.Horizontal = horizontal;
            this.Vertical = vertical;
        }

        public double Vertical
        {
            get { return this.vertical; }
            set { this.vertical = value; }
        }

        public double Horizontal
        {
            get { return this.horizontal; }
            set { this.horizontal = value; }
        }
        
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public static string AreTwoRectanglesInteracting(Rectangle firestRectange, Rectangle secondRectangle)
        {
            if (firestRectange.Horizontal > secondRectangle.Horizontal + secondRectangle.Width
                || firestRectange.Vertical - firestRectange.Height > secondRectangle.Vertical 
                || secondRectangle.Horizontal > firestRectange.Horizontal + firestRectange.Width
                || secondRectangle.Vertical - secondRectangle.Height > firestRectange.Vertical)
            {
                return "false";
            }

            return "true";
        }

    }
}
