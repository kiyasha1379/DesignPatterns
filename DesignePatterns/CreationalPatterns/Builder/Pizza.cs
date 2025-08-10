
namespace DesignePatterns.CreationalPatterns.Builder
{
    public class Pizza
    {
        public bool HasCheese { get; set; }
        public bool HasPepperoni { get; set; }
        public bool HasMushroom { get; set; }

        public override string ToString()
        {
            var toppings = new List<string>();
            if (HasCheese) toppings.Add("Cheese");
            if (HasPepperoni) toppings.Add("Pepperoni");
            if (HasMushroom) toppings.Add("Mushroom");
            return $"Pizza with: {string.Join(", ", toppings)}";
        }
    }
}
