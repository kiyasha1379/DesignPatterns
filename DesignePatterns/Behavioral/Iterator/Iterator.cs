
namespace DesignePatterns.Behavioral.Iterator
{
    //  Iterator
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
    }

    //  Collection
    public interface IAggregate<T>
    {
        IIterator<T> CreateIterator();
    }
    public class NameCollection : IAggregate<string>
    {
        private readonly List<string> _names = new() { "Ali", "Sara", "Reza" };

        public IIterator<string> CreateIterator() => new NameIterator(_names);

        private class NameIterator : IIterator<string>
        {
            private readonly List<string> _list;
            private int _index = 0;

            public NameIterator(List<string> list) => _list = list;

            public bool HasNext() => _index < _list.Count;

            public string Next() => _list[_index++];
        }
    }
}
