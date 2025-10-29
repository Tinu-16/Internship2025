using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankingConsoleApp2
{
    public class AccountOperations
    {
        private readonly BankingAppDbContext _context;
        public AccountOperations(BankingAppDbContext context)
        {
            _context = context;
        }
        public void Add(Customer customer)
        {
            try
            {
                _context.Add(customer);
                int result = _context.SaveChanges();

                if (result > 0)
                {
                    Console.WriteLine("Customer inserted successfully");
                }
                else
                {
                    Console.WriteLine("Customer not inserted successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Display()
        {
            List<Customer> customers = _context.Customers
                                       .Include(c => c.Address)
                                       .Include(c => c.Account)
                                       .ToList();
            if (customers.Count > 0)
            {
                foreach (Customer customer in customers)
                {
                    string accountsDetail = string.Join(", ", customer.Account.Select(a =>
                    $"{a.AccountNumber} ({a.Balance})"));
                    Console.WriteLine($"{customer.FullName} : <>; Address : <{customer.Address.Street},{customer.Address.City} ,{customer.Address.State} ,{customer.Address.PostalCode} ,{customer.Address.Country}>; Account : <{accountsDetail}>");

                }
            }
            else
            {
                Console.WriteLine("The customer table is empty");
            }
        }

        public void AddAddress(int customerId, Address newAddress)
        {
            try
            {
                var customer = _context.Customers.Include(c => c.Address).FirstOrDefault(c => c.Id == customerId);

                if (customer.Address == null)
                {
                    newAddress.CustomerId = customerId;
                    _context.Addresses.Add(newAddress);
                }
                else
                {
                    customer.Address.Street = newAddress.Street;
                    customer.Address.City = newAddress.City;
                    customer.Address.State = newAddress.State;
                    customer.Address.PostalCode = newAddress.PostalCode;
                    customer.Address.Country = newAddress.Country;
                }
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void AddAccount(int customerId, Account account)
        {
            try
            {
                var customer = _context.Customers.FirstOrDefault(a => a.Id == customerId);
                if (customer == null)
                {
                    Console.WriteLine($"Customer with customer id : {customerId} does not exists");
                }
                else
                {
                    account.CustomerId = customerId;
                    _context.Accounts.Add(account);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void DeleteAccount(int customerId, int accountId)
        {
            try
            {
                var account = _context.Accounts.FirstOrDefault(a => a.Id == accountId && a.CustomerId== customerId);
                if (account == null)
                {
                    Console.WriteLine($"Account id does not exist");
                }
                else
                {
                    _context.Accounts.Remove(account);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }


    }
}
