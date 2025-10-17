using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    internal class Employee
    {
        public string Id{ get; private set;}
        public string Name{ get; set; }
        public double Salary { get; set; }
        public string EmployeeType { get; set; }

        static int _count;
        static int _employeeId;
        static Employee()
        {
            _count = 0;
            _employeeId = 1000;
        }

        public Employee(string name, double salary, string employeeType)
        {
            _count++;
            Id = "Emp"+ _employeeId;
            _employeeId++;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }

        public static int NoOfEmployees()
        {
            return _count;
        }
        public static string NextAvailableEmployeeId()
        {
            return "Emp"+ _employeeId;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Id : "+Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Salary : " + Salary);
            Console.WriteLine("Employee Type : " + EmployeeType);
        }


    }
}
