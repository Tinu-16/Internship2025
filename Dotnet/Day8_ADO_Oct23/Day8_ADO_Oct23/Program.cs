using Day8_ADO_Oct23;

StudentDBOperations studentDBOperations = new StudentDBOperations();
Console.WriteLine("Enter the name");
string studentName = Console.ReadLine();
Console.WriteLine("Enter the class");
string studentClass = Console.ReadLine();
studentDBOperations.InsertData(studentName, studentClass);

Console.WriteLine("Enter the id");
int id = int.Parse(Console.ReadLine());
studentDBOperations.GetStudentByIdAndPrint(id);

Console.WriteLine("Enter the name");
string name = Console.ReadLine();
Console.WriteLine("Enter the class");
string stdclass = Console.ReadLine();
studentDBOperations.InsertStudent(name, stdclass);

Console.WriteLine("Enter the id");
int id1 = int.Parse(Console.ReadLine());
studentDBOperations.DeleteStudent(id1);

Console.WriteLine("Enter the id");
int id2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the name");
string stdName = Console.ReadLine();
Console.WriteLine("Enter the class");
string stdClass = Console.ReadLine();
studentDBOperations.UpdateStudent(id2, stdName, stdClass);

EmployeeDbOperations employeeDBOperations = new EmployeeDbOperations();
Console.WriteLine("Enter the name");
string empName = Console.ReadLine();
Console.WriteLine("Enter the salary");
double empSal = double.Parse(Console.ReadLine());
employeeDBOperations.InsertData(empName, empSal);
employeeDBOperations.DisplayEmployee();


Console.WriteLine("Enter the id");
int empId = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the salary");
double empSalary = double.Parse(Console.ReadLine());
employeeDBOperations.UpdateEmployee(empId, empSalary);

Console.WriteLine("Enter the id");
int employeeId = int.Parse(Console.ReadLine());
employeeDBOperations.DeleteEmployee(employeeId);

employeeDBOperations.TotalEmployees();
employeeDBOperations.DisplayEmployeeDataDisconnected();
employeeDBOperations.RetrieveModifyUpdate();
