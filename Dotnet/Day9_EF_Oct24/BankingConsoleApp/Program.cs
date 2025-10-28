using BankingConsoleApp;

BankingAppDbContext context=new BankingAppDbContext();

Customer customer =new Customer();
customer.FullName = "John Smith";
customer.Email = "john.smith@email.com";
customer.PhoneNumber = "-857";
customer.DateOfBirth = DateTime.Parse("1987 - 04 - 12");
customer.Address = "123 Main St, New York, USA";
customer.CreatedDate = DateTime.Parse("2025-01-01");

context.Customers.Add(customer);

Customer customer1 = new Customer();
customer1.FullName = "Maria Gonzalez";
customer1.Email = "maria.gonzalez@gmail.com";
customer1.PhoneNumber = "-1601";
customer1.DateOfBirth = DateTime.Parse("1990-08-25");
customer1.Address = "45 Calle Mayor, Madrid, Spain";
customer1.CreatedDate = DateTime.Parse("2025-02-15");

context.Customers.Add(customer1);

Customer customer2 = new Customer();
customer2.FullName = "Liam O’Connor";
customer2.Email = "liam.oconnor@outlook.com";
customer2.PhoneNumber = "-907779";
customer2.DateOfBirth = DateTime.Parse("1985-11-03");
customer2.Address = "89 Abbey Rd, London, UK";
customer2.CreatedDate = DateTime.Parse("2025-03-10");

context.Customers.Add(customer2);

Customer customer3 = new Customer();
customer3.FullName = "Sophia Müller";
customer3.Email = "sophia.mueller@gmail.com";
customer3.PhoneNumber = "-2345780";
customer3.DateOfBirth = DateTime.Parse("1992-07-18");
customer3.Address = "22 Berliner Str, Berlin, Germany";
customer3.CreatedDate = DateTime.Parse("2025-04-05");

context.Customers.Add(customer3);

Customer customer4 = new Customer();
customer4.FullName = "Ethan Brown";
customer4.Email = "ethan.brown@yahoo.com";
customer4.PhoneNumber = "-1374";
customer4.DateOfBirth = DateTime.Parse("1989-02-14");
customer4.Address = "17 King St, Sydney, Australia";
customer.CreatedDate = DateTime.Parse("2025-05-01");

context.Customers.Add(customer4);
int result = context.SaveChanges();

AccountOperations accountOperations = new AccountOperations();
Customer customers = new Customer();

Console.WriteLine("Enter the full name: ");
customers.FullName = Console.ReadLine();

Console.WriteLine("Enter the email: ");
customers.Email = Console.ReadLine();

Console.WriteLine("Enter the phone no: ");
customers.PhoneNumber = Console.ReadLine();

Console.WriteLine("Enter the Date of Birth: ");
customers.DateOfBirth = DateTime.Parse(Console.ReadLine());

Console.WriteLine("Enter the Address: ");
customers.Address = Console.ReadLine();

Console.WriteLine("Enter the created date: ");
customers.CreatedDate = DateTime.Parse(Console.ReadLine());
accountOperations.Add(customers);

Console.WriteLine("Enter the Id of the customer to be updated ");
int id = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the Address: ");
string addr = Console.ReadLine();
accountOperations.Update(id, addr);

Console.WriteLine("Enter the Id of the customer to be deleted ");
int customerid = int.Parse(Console.ReadLine());
accountOperations.Delete(customerid);

accountOperations.Display();