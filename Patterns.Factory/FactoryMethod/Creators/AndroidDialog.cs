using System.Drawing;
using Patterns.Factory.FactoryMethod.Products;

namespace Patterns.Factory.FactoryMethod.Creators;

internal class AndroidDialog : Dialog
{
    protected override IButton CreateButton()
    {
        return new AndroidButton();
    }

    private class AndroidButton : IButton
    {
        public void OnClick(Action action)
        {
            throw new NotImplementedException();
        }

        public void Render()
        {
            throw new NotImplementedException();
        }

        public void SetColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
