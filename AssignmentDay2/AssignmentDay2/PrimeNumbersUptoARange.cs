using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class PrimeNumbersUptoARange
    {
        public static void PrimeNumbersUptoRange()
        {
            for (int i = 2; i < 100; i++)
            {
                bool flag = true; ;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                        break;
                    }

                }
                if (flag)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
