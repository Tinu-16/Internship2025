using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class CheckPrime
    {
        public static void CheckPrimeNum(int num)
        {
            bool flag = true; ;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    flag = false;
                    break;
                }
               
            }
            if(flag)
            {
                Console.WriteLine("Prime number");
            }
            else
            {
                Console.WriteLine("Not Prime number");
            }

        }
    }
}
