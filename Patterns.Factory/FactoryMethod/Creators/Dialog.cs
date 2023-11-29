using System.Drawing;
using Patterns.Factory.FactoryMethod.Products;

namespace Patterns.Factory.FactoryMethod.Creators;

internal abstract class Dialog
{
    void ProceedPromt()
    {
        var button = CreateButton();

        button.SetColor(Color.Yellow);
        button.OnClick(() => { });
        button.Render();
    }

    // Nothing special, just abstracts the creation and enforces you to stick to the given code structure by using inheritance.
    // This approach is not super good but it could be the case in some scenarios.
    // Composition is about flexibility (when random things flying around which you have to put together).
    // Inheritance is about structure (when things are rigid and heavy for changes).
    protected abstract IButton CreateButton();
}
