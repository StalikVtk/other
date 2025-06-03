namespace Practice3.Task8
{
    public struct Rectangle
    {
        public double width { get; }
        public double height { get; }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public static double SquareRectangle(Rectangle rect)
        {
            return rect.width * rect.height;
        }
    }
}
