using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class ArithmeticOperations
    {
        public void Add(int num1, int num2) 
        { 
            Console.WriteLine("Sum "+ (num1 +num2));
        }

        public void Subtract(int num1, int num2)
        {
            Console.WriteLine("Difference "+ (num2 - num1));
        }

        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine("Product " + (num1 * num2));
        }
        public void Division(int num1, int num2)
        {
            Console.WriteLine("Division ans: "+(num1 / num2));
        }
    }
}
