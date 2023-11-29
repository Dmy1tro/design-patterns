using Patterns.Factory.AbstractFactory.Products;

namespace Patterns.Factory.AbstractFactory.Factories;

internal class AndroidFactory : IUIFactory
{
    public IButton CreateButton()
    {
        return new AndroidButton();
    }

    public IInput CreateInput()
    {
        return new AndroidInput();
    }

    // Group of UI elements specific for android platform
    // Factory makes sure that all created objects are compatible together
    private class AndroidButton : IButton
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

    private class AndroidInput : IInput
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
