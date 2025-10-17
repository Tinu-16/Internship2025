using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SwapUsingRef
    {
        public void SwapUsingRefKeyword(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
