namespace DesignePatterns.Behavioral.Strategy
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
            => Console.WriteLine($"Paid {amount} with Credit Card.");
    }
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
            => Console.WriteLine($"Paid {amount} with PayPal.");
    }

    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Checkout(decimal amount)
            =>_paymentStrategy.Pay(amount);
    }
}
