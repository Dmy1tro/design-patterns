namespace Patterns.Builder;

internal class ButtonBuilder
{
    private Button _button = new();

    // Entry point
    public ButtonBuilder()
    {

    }

    // Entry point
    public static ButtonBuilder CreateBuilder()
    {
        return new ButtonBuilder();
    }

    public ButtonBuilder WithText(string text)
    {
        // Here can be validation or pre-processing of value before setting it to the object
        _button.Text = text;
        return this;
    }

    public ButtonBuilder WithColor(string color)
    {
        _button.Color = color;
        return this;
    }

    // Other 'With' methods...

    public Button Build() => _button;

    public void Example()
    {
        var button = ButtonBuilder
            .CreateBuilder()
            .WithText("Confirm")
            .WithColor("White")
            .Build();

        var cancelButton = new ButtonBuilder()
            .WithText("Cancel")
            .Build();
    }
}
