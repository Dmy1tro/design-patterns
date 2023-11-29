using Patterns.Factory.AbstractFactory.Products;

namespace Patterns.Factory.AbstractFactory.Factories;

internal interface IUIFactory
{
    IButton CreateButton();

    IInput CreateInput();
}
