using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    static class StaticAverage
    {
        public static double AverageExceptZero(this List<int> list)
        {
            var numbersWithoutZero = list.Where(n => n != 0);

            if(numbersWithoutZero.Count() > 0)
                return numbersWithoutZero.Average();
            else
                return 0;
        }
    }
}
