namespace DesignePatterns.Behavioral.Mediator
{
    public abstract class User
    {
        protected readonly IChatMediator _chatMediator;
        protected string name;

        protected User(IChatMediator chatMediator, string name)
        {
            _chatMediator = chatMediator;
            this.name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message);

    }

    // Mediator Interface

    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void AddUser(User user);
    }
    // Concrete Mediator
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new();
        public void AddUser(User user)
            => _users.Add(user);

        public void SendMessage(string message, User user)
        {
            foreach (var item in _users)
            {
                if (item != user)
                    item.Receive(message);
            }
        }
    }
    // Concrete Colleague
    public class ChatUser : User
    {
        public ChatUser(IChatMediator chatMediator, string name) : base(chatMediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine($"{name} ارسال کرد: {message}");
            _chatMediator.SendMessage(message, this);
        }

        public override void Send(string message)
            => Console.WriteLine($"{name} دریافت کرد: {message}");
    }
}
