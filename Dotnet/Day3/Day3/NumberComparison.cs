using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class NumberComparison
    {
        public static void NumberComparisonUsingRelational(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine("Both numbers are equal");
            }
            else if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater");
            }
            else
            {
                Console.WriteLine(num2 + " is greater");
            }
        }
        public static void NumberComparisonUsingLogical(int num1)
        {
                Console.WriteLine(num1 > 5 && num1 < 10);
                Console.WriteLine(num1 > 3 || num1 < 4);
        }
    }
}
