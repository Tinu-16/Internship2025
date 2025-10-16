using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class NumbersBetweenTenAndFifty
    {
        public void NumberBetweenTenAndFifty(int num)
        {
            if (num >= 10 && num <= 50)
            {
                Console.WriteLine("The number lies between 10 and 50");
            }
            else
            {
                Console.WriteLine("The number doesn't lie between 10 and 50");
            }
        }
    }
}
