using Newtonsoft.Json;

namespace Patterns.Prototype
{
    internal abstract class Shape
    {
        public Shape()
        {
        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public abstract Shape Clone();

        public Shape CloneV2()
        {
            var json = JsonConvert.SerializeObject(this);
            var clone = JsonConvert.DeserializeObject(json, GetType()) as Shape;

            return clone;
        }
    }
}
