using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Calculator
    {
        public void CalculatorResult(int num1,int num2)
        {
            Console.WriteLine("Choose the operation to be performed");
            Console.WriteLine("1.Addition \n2.Subtraction \n3.Multiplication \n4.Division");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
    }
}
