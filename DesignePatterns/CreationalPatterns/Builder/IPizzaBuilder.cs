

namespace DesignePatterns.CreationalPatterns.Builder
{
    public interface IPizzaBuilder
    {
        void AddCheese();
        void AddPepperoni();
        void AddMushroom();
        Pizza Build();
    }
}
