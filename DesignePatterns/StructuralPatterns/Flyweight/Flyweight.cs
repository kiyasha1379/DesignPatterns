namespace DesignePatterns.StructuralPatterns.Flyweight
{
    // Flyweight
    public interface ICharacter
    {
        void Display(int position);
    }

    // ConcreteFlyweight 
    public class Character : ICharacter
    {
        private readonly char _symbol; // intrinsic state
        private readonly string _font;

        public Character(char symbol, string font)
        {
            _symbol = symbol;
            _font = font;
        }

        public void Display(int position) // extrinsic state: position
            => Console.WriteLine($"Character {_symbol} in font {_font} at position {position}");

    }

    // FlyweightFactory 
    public class CharacterFactory
    {
        private readonly Dictionary<char, ICharacter> _characters = new();

        public ICharacter GetCharacter(char symbol)
        {
            if (!_characters.ContainsKey(symbol))
            {
                // برای سادگی فقط فونت پیش‌فرض می‌گذاریم
                _characters[symbol] = new Character(symbol, "Arial");
            }

            return _characters[symbol];
        }
    }
}
