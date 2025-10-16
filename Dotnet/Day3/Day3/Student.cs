using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class Student
    {
        string name;
        int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayMethod()
        {
            Console.WriteLine("Name is "+name);
            Console.WriteLine("Age is "+age);
        }
    }
}
