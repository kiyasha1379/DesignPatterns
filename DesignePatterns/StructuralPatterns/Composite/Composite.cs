

namespace DesignePatterns.StructuralPatterns.Composite
{
    public interface IFileSystemItem
    {
        void Display(int depth);
    }

    //  (Leaf)
    public class Filee : IFileSystemItem
    {
        private readonly string _name;

        public Filee(string name)
        {
            _name = name;
        }

        public void Display(int depth)
           =>Console.WriteLine(new string('-', depth) + _name);
    }

    //  (Composite)
    public class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _items = new();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemItem item)
            =>_items.Add(item);

        public void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + _name);

            foreach (var item in _items)
                item.Display(depth + 2);
        }
    }

}
