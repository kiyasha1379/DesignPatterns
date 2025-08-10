
namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public class LightButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Light Button");
    }
}
