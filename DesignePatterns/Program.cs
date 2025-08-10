#region Creantional

#region Singelton

//using DesignePatterns.CreationalPatterns.Singelton;
//Logger.Instance.Log("Application Start");
//Console.ReadKey();
#endregion

#region FactoryMethod

//using DesignePatterns.CreationalPatterns.FactoryMethod;

//Console.WriteLine("نوع پرداخت را وارد کنید (zarinpal / paypal):");
//string type = Console.ReadLine()?.ToLower();

//Console.WriteLine("مبلغ را وارد کنید:");
//decimal amount = decimal.Parse(Console.ReadLine());

//PaymentFactory factory = type switch
//{
//    "zarinpal" => new ZarinpalFactory(),
//    "paypal" => new PayPalFactory(),
//    _ => throw new ArgumentException("درگاه پرداخت نامعتبر است")
//};

//IPaymentService paymentService = factory.CreatePaymentService();
//paymentService.Pay(amount);

//Console.WriteLine("پرداخت با موفقیت انجام شد ✅");

// با استفاده از Reflection

//Console.WriteLine("نوع پرداخت را وارد کنید (Zarinpal / PayPal):");
//string type = Console.ReadLine();

//Console.WriteLine("مبلغ را وارد کنید:");
//decimal amount = decimal.Parse(Console.ReadLine());

//var paymentService = PaymentFactory.CreatePaymentService(type);
//paymentService.Pay(amount);

//Console.WriteLine("پرداخت با موفقیت انجام شد ✅");
#endregion

#region AbstractFactory

using DesignePatterns.CreationalPatterns.AbstractFactory;
using DesignePatterns.CreationalPatterns.Builder;
using DesignePatterns.CreationalPatterns.Prototype;

//Console.WriteLine("Choose Theme: Dark / Light");
//string theme = Console.ReadLine();

//IUIFactory factory;

//if (theme.Equals("Dark", StringComparison.OrdinalIgnoreCase))
//    factory = new DarkUIFactory();
//else
//    factory = new LightUIFactory();

//var button = factory.CreateButton();
//var checkbox = factory.CreateCheckbox();

//button.Render();
//checkbox.Render();
#endregion

#region Builder

//var builder = new PizzaBuilder();

//builder.AddCheese();
//builder.AddMushroom();

//var pizza = builder.Build();

//Console.WriteLine(pizza);
#endregion

#region Prototype

//var original = new Person { Name = "Kiyasha", Age = 30 };
//var copy = original.Clone();

//copy.Name = "Ali";

//Console.WriteLine("Original: " + original);
//Console.WriteLine("Copy: " + copy);
#endregion


#endregion