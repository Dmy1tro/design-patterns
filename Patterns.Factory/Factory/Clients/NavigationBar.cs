using Patterns.Factory.Factory.Factories;
using Patterns.Factory.Factory.Products;

namespace Patterns.Factory.Factory.Clients
{
    internal class NavigationBar
    {
        private readonly Button _button;

        public NavigationBar()
        {
            _button = ButtonFactory.CreateButton();
        }
    }
}
