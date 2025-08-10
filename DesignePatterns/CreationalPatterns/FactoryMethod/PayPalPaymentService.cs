namespace DesignePatterns.CreationalPatterns.FactoryMethod
{
    public class PayPalPaymentService : IPaymentService
    {
        public void Pay(decimal amount)
            => Console.WriteLine($"Paying {amount} USD via PayPal");

    }
}
