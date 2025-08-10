namespace DesignePatterns.CreationalPatterns.AbstractFactory
{
    public class DarkButton : IButton
    {
        public void Render() => Console.WriteLine("Rendering Dark Button");
    }
}
