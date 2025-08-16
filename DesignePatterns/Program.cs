
#region Creantional

//Console.WriteLine("For check the creantional Patterns Check the creantional folder ");

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

//using DesignePatterns.CreationalPatterns.AbstractFactory;
//using DesignePatterns.CreationalPatterns.Builder;
//using DesignePatterns.CreationalPatterns.Prototype;

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
//using DesignePatterns.CreationalPatterns.Builder;

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

#region StructuralPatterns

#region Adapter

//using DesignePatterns.StructuralPatterns.Adapter;
//ExternalUserApi externalApi = new ExternalUserApi();
//IUserService userService = new UserServiceAdapter(externalApi);
//Console.WriteLine(userService.GetUserName());
#endregion

#region Facade

//using DesignePatterns.StructuralPatterns.Facade;

//var light = new LightSystem();
//var ac = new AirConditioningSystem();
//var security = new SecuritySystem();

//var homeFacade = new SmartHomeFacade(light, ac, security);

//homeFacade.LeaveHome();
//Console.WriteLine();

//homeFacade.ArriveHome();
#endregion

#region Composite 

//using DesignePatterns.StructuralPatterns.Composite;

//var file1 = new Filee("file1.txt");
//var file2 = new Filee("file2.txt");
//var file3 = new Filee("file3.text");

//var folder1 = new Folder("Documents");
//folder1.Add(file1);
//folder1.Add(file2);

//var folder2 = new Folder("MyFolder");
//folder2.Add(folder1);
//folder2.Add(new Filee("file3.txt"));

//var folder3 = new Folder("Basefolder");
//folder3.Add(folder2);
//folder3.Add(file3);

//folder3.Display(0);
//Console.ReadKey();
#endregion

#region  Decorator

//using DesignePatterns.StructuralPatterns.Decorator;

//IOrder order = new BasicOrder();

//order = new DiscountDecorator(order);
//order = new NotificationDecorator(order);

//order.ProcessOrder();
#endregion

#region Flyweight 

//var factory = new DesignePatterns.StructuralPatterns.Flyweight.CharacterFactory();
//var document = "HELLO FLYWEIGHT";

//for (int i = 0; i < document.Length; i++)
//{
//    var character = factory.GetCharacter(document[i]);
//    character.Display(i);
//}
#endregion

#region Proxy 

//using DesignePatterns.StructuralPatterns.Proxy;

//IFile file = new ProxyFile("test_file.pdf");

//// Load the real file
//file.Display();

//// just show file 
//file.Display();
#endregion

#region Bridge

#endregion

#endregion