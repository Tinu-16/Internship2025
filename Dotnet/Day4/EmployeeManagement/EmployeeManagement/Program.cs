using EmployeeManagement;

Employee employee1 = new Employee("John Doe", 15000, "Permanent");
Employee employee2 = new Employee("Liam Smith", 20000, "Contract");
Employee employee3 = new Employee("Mary James", 15000, "Permanent");
employee1.DisplayDetails();
employee2.DisplayDetails();
employee3.DisplayDetails();
Console.WriteLine(Employee.NoOfEmployees());
Console.WriteLine(Employee.NextAvailableEmployeeId());