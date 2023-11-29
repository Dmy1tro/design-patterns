using Patterns.Factory.Factory.Products;

namespace Patterns.Factory.Factory.Factories;

internal class ButtonFactory
{
    // Simple factory, common scenario.
    public static Button CreateButton() => new() { Type = "Primary button" };
}
