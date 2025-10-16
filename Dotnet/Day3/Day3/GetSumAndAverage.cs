using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class GetSumAndAverage
    {
        //Write a method GetSumAndAverage(int a, int b, out int sum, out double avg) that returns sum and average using out parameters.
        public static void GetSumAndAverageofNumbers(int a, int b, out int sum, out double avg)
        {
            sum = a + b;
            avg = sum / 2;
            Console.WriteLine("Sum is "+sum);
            Console.WriteLine("Average is " + avg);
        }
    }
}
