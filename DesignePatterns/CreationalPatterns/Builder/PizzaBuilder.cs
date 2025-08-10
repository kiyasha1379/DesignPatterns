

namespace DesignePatterns.CreationalPatterns.Builder
{
    public class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza = new Pizza();

        public void AddCheese() => _pizza.HasCheese = true;
        public void AddPepperoni() => _pizza.HasPepperoni = true;
        public void AddMushroom() => _pizza.HasMushroom = true;

        public Pizza Build()
            => _pizza;
    }
}
