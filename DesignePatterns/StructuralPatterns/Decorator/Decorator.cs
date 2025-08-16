
namespace DesignePatterns.StructuralPatterns.Decorator
{
    // Component
    public interface IOrder
    {
        void ProcessOrder();
    }

    // ConcreteComponent 
    public class BasicOrder : IOrder
    {
        public void ProcessOrder()
            => Console.WriteLine("Processing basic order.");
    }

    // Decorator
    public abstract class OrderDecorator : IOrder
    {
        protected IOrder _order;

        public OrderDecorator(IOrder order)
        {
            _order = order;
        }

        public virtual void ProcessOrder()
            => _order.ProcessOrder();
    }

    // ConcreteDecorator 
    public class DiscountDecorator : OrderDecorator
    {
        public DiscountDecorator(IOrder order) : base(order) { }

        public override void ProcessOrder()
        {
            base.ProcessOrder();
            ApplyDiscount();
        }

        private void ApplyDiscount()
            =>Console.WriteLine("Applying discount to the order.");
    }

    // ConcreteDecorator 
    public class NotificationDecorator : OrderDecorator
    {
        public NotificationDecorator(IOrder order) : base(order) { }

        public override void ProcessOrder()
        {
            base.ProcessOrder();
            SendNotification();
        }

        private void SendNotification()
            =>Console.WriteLine("Sending notification about the order.");
    }
}
