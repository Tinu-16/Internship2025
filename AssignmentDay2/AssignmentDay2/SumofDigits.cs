using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class SumofDigits
    {
        public static void SumOfDigits(int num)
        {
            int n = num;
            int reverse = 0;
            while (num > 0)
            {
                int remainder = num % 10;
                reverse = reverse  + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse of the number " + n + " is " + reverse);
        }
    }
}
