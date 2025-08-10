
namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public class DarkUIFactory : IUIFactory
    {
        public IButton CreateButton() => new DarkButton();
        public ICheckbox CreateCheckbox() => new DarkCheckbox();
    }
}
