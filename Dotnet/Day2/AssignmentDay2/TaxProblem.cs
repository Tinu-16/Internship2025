using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay2
{
    internal class TaxProblem
    {
        public static void TaxProblems(int amt)
        {
            double tax;
            if (amt < 10000)
            {
                tax = amt * 0.5;
                Console.WriteLine(" Tax for amount " + amt + " is " + tax);
            }
            else if (amt >= 10000 && amt < 15000)
            {
                tax = amt * (7.5 / 100);
                Console.WriteLine(" Tax for amount " + amt + " is " + tax);
            }
            else if (amt >= 15000 && amt < 20000)
            {
                tax = amt * (0.1);
                Console.WriteLine(" Tax for amount " + amt + " is " + tax);
            }
            else if (amt >= 20000 && amt < 25000)
            {
                tax = amt * (12.5 / 100);
                Console.WriteLine(" Tax for amount " + amt + " is " + tax);
            }
            else
            {
                tax = amt * (0.15);
                Console.WriteLine(" Tax for amount " + amt + " is " + tax);
            }
        }
    }
}
