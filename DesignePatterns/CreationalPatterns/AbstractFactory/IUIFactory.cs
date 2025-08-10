
namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
