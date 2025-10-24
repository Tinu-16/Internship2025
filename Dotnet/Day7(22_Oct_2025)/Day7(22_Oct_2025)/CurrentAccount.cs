using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_Oct22
{
    internal class CurrentAccount : IAccount
    {
        private double _balance;
        public void Deposit(double amount)
        {
            _balance = _balance + amount;
            Console.WriteLine($"Deposited Rs.{amount} successfully using Current Account");
        }
        public void Withdraw(double amount)
        {
            if (_balance >= amount)
            {
                _balance = _balance - amount;
                Console.WriteLine($"Withdrawn an amount of Rs.{amount} successfully");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
