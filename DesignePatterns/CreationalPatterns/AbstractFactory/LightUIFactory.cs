
namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public class LightUIFactory : IUIFactory
    {
        public IButton CreateButton() => new LightButton();
        public ICheckbox CreateCheckbox() => new LightCheckbox();
    }
}
