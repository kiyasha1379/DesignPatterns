

using System.Reflection;

namespace DesignePatterns.CreationalPatterns.FactoryMethod
{
    public abstract class PaymentFactory
    {
        // بدون استفاده از Reflection
        public abstract IPaymentService CreatePaymentService();

        // با استفاده از Reflection
        public static IPaymentService CreatePaymentService(string paymentType)
        {
            // همه کلاس‌هایی که IPaymentService را پیاده‌سازی کرده‌اند پیدا می‌کنیم
            var paymentClass = Assembly.GetExecutingAssembly()
                                       .GetTypes()
                                       .FirstOrDefault(t =>
                                           typeof(IPaymentService).IsAssignableFrom(t) &&
                                           !t.IsInterface &&
                                           t.Name.StartsWith(paymentType, StringComparison.OrdinalIgnoreCase));

            if (paymentClass == null)
                throw new ArgumentException("درگاه پرداخت پیدا نشد");
            
            return (IPaymentService)Activator.CreateInstance(paymentClass);
        }
    }
}
