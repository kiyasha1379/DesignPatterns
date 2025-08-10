
namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public class DarkCheckbox : ICheckbox
    {
        public void Render() => Console.WriteLine("Rendering Dark Checkbox");
    }
}
