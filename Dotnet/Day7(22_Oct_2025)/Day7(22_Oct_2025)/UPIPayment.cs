using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    internal class UPIPayment: IPaymentService
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"UPI Payment done successfully of an amount Rs.{amount}");
        }
    }
}
