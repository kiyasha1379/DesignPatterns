

namespace DesignePatterns.CreationalPatterns.Singelton
{
    public sealed class Logger
    {
        private static readonly Logger _Logger = new Logger();
        private Logger() { }
        public static Logger Instance => _Logger;
        public void Log(string message)
            => Console.WriteLine($"[Log] {message}");
    }
}
