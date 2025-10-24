using Day7_Oct22;

//Question1
string str = "i LOve programming";
Console.WriteLine(str.ToTitleCase());

//Question2
List<int> numbers = new List<int> { 0, 0, 0, 0, 0 };
Console.WriteLine(numbers.AverageExceptZero());

//Question3
Animal animal1 = new Dog();
animal1.Speak();

Animal animal2 = new Cat();
animal2.Speak();

//Question4
Vehicle vehicle1 = new Vehicle();
vehicle1.ShowType();

Car car = new Car();
car.ShowType();

Vehicle vehicle2 = new Car();
vehicle2.ShowType();

//Question5
IAccount savings = new SavingsAccount();
savings.Deposit(20000);
Console.WriteLine($"Available balance is : {savings.GetBalance()}");
savings.Withdraw(2000);
Console.WriteLine($"Available balance is : {savings.GetBalance()}");

IAccount current = new CurrentAccount();
current.Deposit(80000);
Console.WriteLine($"Available balance is : {current.GetBalance()}");
current.Withdraw(10000);
Console.WriteLine($"Available balance is : {current.GetBalance()}");

IPaymentService service = new CreditCardPayment();
PaymentProcessor paymentProcessor=new PaymentProcessor(service);
paymentProcessor.ProcessPayment(1000);

//Question6
INotificationService notification = new EmailNotifier();
AppointmentService appointmentService= new AppointmentService(notification);
appointmentService.AppointmentNotify("Tinu");
