using System.Drawing;

namespace Patterns.Factory.FactoryMethod.Products
{
    internal interface IButton
    {
        void OnClick(Action action);

        void SetColor(Color color);

        void Render();
    }
}
