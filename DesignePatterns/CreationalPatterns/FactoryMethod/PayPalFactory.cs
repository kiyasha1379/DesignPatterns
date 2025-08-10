namespace DesignePatterns.CreationalPatterns.FactoryMethod
{
    public class PayPalFactory : PaymentFactory
    {
        public override IPaymentService CreatePaymentService()
                => new PayPalPaymentService();
    }
}
