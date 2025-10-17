using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class Largest
    {
        public static void LargestAmongThree(int a,int b,int c)
        {
            if (a >= b && a >= c)
                Console.WriteLine(a + " is largest");
            else if (b >= c)
                Console.WriteLine(b + " is largest");
            else
                Console.WriteLine(c + " is largest");
        }
    }
}
