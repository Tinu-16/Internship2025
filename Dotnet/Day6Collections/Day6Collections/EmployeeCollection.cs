using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day6Collections
{
    internal class EmployeeCollection
    {
        List<Employee> employeeCollections = new List<Employee>();

        public void AddEmployee(string name, double salary, string employeeType)
        {
            Employee employee = new Employee(name, salary, employeeType);
            employeeCollections.Add(employee);
            Console.WriteLine("Employee added successfully");
        }

        public void RemoveEmployee(string id)
        {
            var employee1 = employeeCollections.FirstOrDefault(a => a.Id == id);
            if (employee1 != null)
            {
                employeeCollections.Remove(employee1);
                Console.WriteLine("Employee removed successfully");
            }
            else
            {
                Console.WriteLine($"No Employee found with Id {id}");
            }
        }

        public void DisplayEmployees()
        {
            foreach (var item in employeeCollections)
            {
                Console.WriteLine($"Id : {item.Id}, Name : {item.Name}, Salary : {item.Salary}, Employment type : {item.EmployeeType}");
            }
        }

        public void SearchEmployee(string name)
        {
            List<Employee> employee2 = employeeCollections.Where(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
            if (employee2.Count > 0)
            {
                foreach (var item in employee2)
                {
                    Console.WriteLine($"Id : {item.Id}, Name : {item.Name}, Salary : {item.Salary}, Employment type : {item.EmployeeType}");
                }
            }
            else
            {
                Console.WriteLine($"No Employee found");
            }
        }

    }
}
