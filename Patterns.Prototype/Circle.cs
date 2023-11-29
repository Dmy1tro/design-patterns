namespace Patterns.Prototype;

internal class Circle : Shape
{
    public Circle()
    {
    }

    public Circle(Circle circle) : base(circle)
    {
        Radius = circle.Radius;
    }

    public double Radius { get; set; }

    public override Circle Clone() => new Circle(this);
}
