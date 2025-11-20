using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Collections
{
    internal class Employee
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string EmployeeType { get; set; }

        static int counter;
        static Employee()
        {
            counter = 1000;
        }
        public Employee(string name, double salary, string employeeType)
        {
            Id = "Emp" + counter;
            counter++;
            Name = name;
            Salary = salary;
            EmployeeType = employeeType;
        }
    }
}
