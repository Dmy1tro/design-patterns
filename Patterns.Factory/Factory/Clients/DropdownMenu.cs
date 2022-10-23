using Patterns.Factory.Factory.Factories;
using Patterns.Factory.Factory.Products;

namespace Patterns.Factory.Factory.Clients
{
    internal class DropdownMenu
    {
        private readonly Button _button;

        public DropdownMenu()
        {
            _button = ButtonFactory.CreateButton();
        }
    }
}
