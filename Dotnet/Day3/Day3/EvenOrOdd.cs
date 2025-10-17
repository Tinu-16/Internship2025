using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class EvenOrOdd
    {
        public static string EvenOrOddCheck(int num) 
        {
            string result = (num % 2 == 0) ? "Even" : "Odd";
            return result;
        }
    }
}
