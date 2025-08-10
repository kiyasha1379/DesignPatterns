namespace DesignePatterns.CreationalPatterns.FactoryMethod
{
    public class ZarinpalPaymentService : IPaymentService
    {
        public void Pay(decimal amount)
           => Console.WriteLine($"پرداخت {amount} تومان با زرین‌پال");
    }
}
