using Patterns.Factory.AbstractFactory.Products;

namespace Patterns.Factory.AbstractFactory.Factories
{
    internal class AppleFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new AppleButton();
        }

        public IInput CreateInput()
        {
            return new AppleInput();
        }

        // Group of UI elements specific for apple platform 
        // Factory makes sure that all created objects are compatible together
        private class AppleButton : IButton
        {
            public void OnClick(Action action)
            {
                throw new NotImplementedException();
            }

            public void SetText(string text)
            {
                throw new NotImplementedException();
            }
        }

        private class AppleInput : IInput
        {
            public void OnChange(Action<string> action)
            {
                throw new NotImplementedException();
            }

            public void SetPlaceholder(string placeholder)
            {
                throw new NotImplementedException();
            }

            public void SetValue(string value)
            {
                throw new NotImplementedException();
            }
        }
    }
}
