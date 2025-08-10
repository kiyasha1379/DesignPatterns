

namespace DesignePatterns.CreationalPatterns.FactoryMethod
{
    public class ZarinpalFactory : PaymentFactory
    {
        public override IPaymentService CreatePaymentService()
            => new ZarinpalPaymentService();
    }
}
