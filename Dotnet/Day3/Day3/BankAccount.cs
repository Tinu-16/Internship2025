using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class BankAccount
    {
        //Create a class BankAccount(AccountNumber, AccountHolder, Balance ) with default and parameterized constructors using constructor chaining.
        //Add Deposit() which increments the balance and DisplayBalance() to display the account details methods.
        long accountNumber;
        string accountHolder;
        double balance;
        public BankAccount() 
        {
            accountNumber = 0;
            accountHolder = "Unknown";
            balance = 0;
        }

        public BankAccount(long AccountNumber, string AccountHolder, double Balance):this()
        {
           this.accountNumber = AccountNumber;
           this.accountHolder = AccountHolder;
           this.balance = Balance;
        }
        public void Deposit(double deposit)
        {
            balance = balance + deposit;
            Console.WriteLine("Deposited Amount: " + deposit);
        }

        public void DisplayBalance()
        {
            Console.WriteLine("AccountNumber : "+accountNumber);
            Console.WriteLine("AccountHolder : "+accountHolder);
            Console.WriteLine("Balance : "+balance);
        }
    }
}
