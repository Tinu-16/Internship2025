using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class ReverseOfNumber
    {
        public static void ReverseOfANumber(int num) 
        {
            int n = num;
            int reverse = 0;
            while(num > 0)
            {
                int remainder= num % 10;
                reverse= reverse *10 + remainder;
                num = num / 10;
            }
            Console.WriteLine("Reverse of the number " + n + " is " + reverse);
        }
    }
}
