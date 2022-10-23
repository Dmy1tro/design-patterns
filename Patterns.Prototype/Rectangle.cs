namespace Patterns.Prototype
{
    internal class Rectangle : Shape
    {
        public Rectangle()
        {

        }

        public Rectangle(Rectangle rectangle) : base(rectangle)
        {
            Width = rectangle.Width;
            Height = rectangle.Height;
        }

        public double Width { get; set; }

        public double Height { get; set; }

        public override Rectangle Clone() => new Rectangle(this);
    }
}
