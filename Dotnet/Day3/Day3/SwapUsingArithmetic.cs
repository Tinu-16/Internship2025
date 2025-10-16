using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SwapUsingArithmetic
    {
        public static void SwapUsingArithmetics(int num1,int num2) 
        {
            num2 = num1 + num2;
            num1 = num2 - num1;
            num2 = num2 - num1;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
