using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class Fibonacci
    {
        public static void FibonacciSeries()
        {
            Console.WriteLine("Enter the limit");
            int num=int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;
            int sum =0;
            Console.WriteLine(a);
            Console.WriteLine(b);
            while (sum <= num) 
            {
                sum = a +b;
                a = b;
                b = sum;
                Console.WriteLine(sum);
            }
        }
    }
}
