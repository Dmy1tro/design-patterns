namespace Patterns.Builder;

internal interface IButton
{
    string Text { get; }

    string Color { get; }

    double Width { get; }

    double Height { get; }
}

internal class Button : IButton
{
    public string Text { get; set; }
           
    public string Color { get; set; }
           
    public double Width { get; set; }
           
    public double Height { get; set; }
}
