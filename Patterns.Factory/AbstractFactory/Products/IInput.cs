namespace Patterns.Factory.AbstractFactory.Products
{
    internal interface IInput
    {
        void OnChange(Action<string> action);

        void SetPlaceholder(string placeholder);

        void SetValue(string value);
    }
}
