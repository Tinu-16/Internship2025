using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Employee
    {       
        public Employee(string name) 
        {
            Console.WriteLine("Name of the Employee "+name);
        }

        public Employee(string name,double salary) : this(name) 
        {
            Console.WriteLine("Salary of the Employee " +salary);
        }
    }
}
