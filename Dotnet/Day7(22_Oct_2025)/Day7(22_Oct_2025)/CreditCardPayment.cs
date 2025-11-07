using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    internal class CreditCardPayment: IPaymentService
    {
       public void MakePayment(double amount)
       {
            Console.WriteLine($"Credit card Payment done successfully of an amount Rs.{amount}");
       }
    }
}
