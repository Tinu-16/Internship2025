using BankingConsoleApp2;

using (var context = new BankingAppDbContext())
{
    AccountOperations accountOperations = new AccountOperations(context);

    var customer = new Customer
    {
        FullName = "Tinu Clara",
        Email = "tinu@gmail.com",
        PhoneNumber = "9856959555",
        DateOfBirth = new DateTime(2020, 07, 10),
        Address = new Address
        {
            Street = "Paloorkavu C.P.O",
            City = "Mundakayam",
            State = "Kerala",
            PostalCode = "685532",
            Country = "India"
        },
        Account = new List<Account>()
    };

    var account = new Account
    {
        AccountNumber = "555555",
        Balance = 3450.99,
    };
    customer.Account.Add(account);
    accountOperations.Add(customer);

    Console.WriteLine("----------Display------------");
    accountOperations.Display();

    Console.WriteLine("Enter the customer id");
    int id = int.Parse(Console.ReadLine());

    Address address1 = new Address();
    Console.WriteLine("Enter the street");
    address1.Street = Console.ReadLine();
    Console.WriteLine("Enter the city");
    address1.City = Console.ReadLine();
    Console.WriteLine("Enter the state");
    address1.State = Console.ReadLine();
    Console.WriteLine("Enter the postal code");
    address1.PostalCode = Console.ReadLine();
    Console.WriteLine("Enter the country");
    address1.Country = Console.ReadLine();
    accountOperations.AddAddress(id, address1);

    Account account1 = new Account();
    Console.WriteLine("Enter the customer id");
    int customerId = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the account no");
    account1.AccountNumber = Console.ReadLine();
    accountOperations.AddAccount(customerId, account1);

    Console.WriteLine("Enter the customer id");
    int customersId = int.Parse(Console.ReadLine());
    Console.WriteLine("Enter the account id");
    int accountId = int.Parse(Console.ReadLine());
    accountOperations.DeleteAccount(customerId, accountId);
}
