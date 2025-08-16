
namespace DesignePatterns.StructuralPatterns.Proxy
{
    // Subject 
    public interface IFile
    {
        void Display();
    }

    // RealSubject 
    public class RealFile : IFile
    {
        private readonly string _fileName;

        public RealFile(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
            => Console.WriteLine($"Loading file {_fileName} from disk...");

        public void Display()
            => Console.WriteLine($"Displaying file {_fileName}");
    }

    // Proxy 
    public class ProxyFile : IFile
    {
        private readonly string _fileName;
        private RealFile _realFile;

        public ProxyFile(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            if (_realFile == null)
                _realFile = new RealFile(_fileName);
            _realFile.Display();
        }
    }

}
