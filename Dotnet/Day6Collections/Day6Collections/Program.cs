using System.Collections;
using Day6Collections;

Question1.Operations();
Question2.Operations();
Question3.Operations();
Question4.Operations();
Question5.Operations();


Console.WriteLine("-----------------------Question6--------------------------");
Console.WriteLine("Welcome to the Employee Management System…\r\n");
EmployeeCollection collection = new EmployeeCollection();
bool flag = true;
while (flag)
{
    Console.WriteLine("Please choose one of the following:\r\n");
    Console.WriteLine("\n1.Add Employee\r\n2.Remove Employee\r\n3.Display All Employees\r\n4.Search Employee\r\n5.Exit\r\n");
    int choice=int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter the name");
            string name=Console.ReadLine();

            Console.WriteLine("Enter the salary");
            double salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Employee type : ");
            string type = Console.ReadLine();

            collection.AddEmployee(name, salary, type);
            break;
        case 2:
            Console.WriteLine("Enter the Id of the employee: ");
            string id = Console.ReadLine();

            collection.RemoveEmployee(id);
            break;
        case 3:
            collection.DisplayEmployees();
            break;
        case 4:
            Console.WriteLine("Enter the name of the employee: ");
            string name1 = Console.ReadLine();

            collection.SearchEmployee(name1);
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Choose a valid option");
            break;
    }
    if (choice == 5)
        break;
}