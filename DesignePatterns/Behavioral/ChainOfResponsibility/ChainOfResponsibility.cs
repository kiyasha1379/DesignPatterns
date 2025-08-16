

namespace DesignePatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler _next;

        public void SetNext(Handler next)
        {
            _next = next;
        }

        public abstract void Handle(string request);
    }

    public class ErrorHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "Error")
                Console.WriteLine("Handled by ErrorHandler");
            else
                _next?.Handle(request);
        }
    }
    public class WarningHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "Warning")
                Console.WriteLine("Handled by WarningHandler");
            else
                _next?.Handle(request);
        }
    }

    public class InfoHandler : Handler
    {
        public override void Handle(string request)
        {
            if (request == "Info")
                Console.WriteLine("Handled by InfoHandler");
            else
                _next?.Handle(request);
        }
    }

    public class NotHandler :Handler
    {
        public override void Handle(string request)
        {
            Console.WriteLine($"The {request} is not handle");
        }
    }
}
