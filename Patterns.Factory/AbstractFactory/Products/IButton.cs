namespace Patterns.Factory.AbstractFactory.Products
{
    internal interface IButton
    {
        void OnClick(Action action);

        void SetText(string text);
    }
}
