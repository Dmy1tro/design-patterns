using Patterns.Factory.AbstractFactory.Factories;
using Patterns.Factory.AbstractFactory.Products;

namespace Patterns.Factory.AbstractFactory.Clients
{
    internal class DropdownMenu
    {
        private readonly IButton _button;
        private readonly IInput _input;

        public DropdownMenu(IUIFactory factory)
        {
            _button = factory.CreateButton();
            _input = factory.CreateInput();
        }
    }
}
