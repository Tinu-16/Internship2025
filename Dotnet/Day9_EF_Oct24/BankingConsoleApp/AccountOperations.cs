using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp
{
    public class AccountOperations
    {
        public void Add(Customer customer)
        {
            using (var dbContext = new BankingAppDbContext())
            {
                dbContext.Customers.Add(customer);
                int result = dbContext.SaveChanges();

                if (result > 0)
                    Console.WriteLine("Customer inserted successfully");
                else
                    Console.WriteLine("Customer not inserted");
            }
        }

        public void Update(int id, string address)
        {
            using (var dbContext = new BankingAppDbContext())
            {
                var customer = dbContext.Customers.FirstOrDefault(x => x.Id == id);

                if (customer != null)
                {
                    customer.Address = address;
                    int result = dbContext.SaveChanges();
                    Console.WriteLine("Customer address updated successfully");
                }
                else
                {
                    Console.WriteLine($"No customer exists with the Id : {id}");
                }
            }
        }

        public void Delete(int id)
        {
            using (var dbContext = new BankingAppDbContext())
            {
                var customer = dbContext.Customers.FirstOrDefault(x => x.Id == id);

                if (customer != null)
                {
                    dbContext.Customers.Remove(customer);
                    int result = dbContext.SaveChanges();
                    Console.WriteLine("Customer deleted successfully");
                }
                else
                {
                    Console.WriteLine($"No customer exists with the Id : {id}");
                }
            }
        }

        public void Display()
        {
            using (var dbContext = new BankingAppDbContext())
            {
                List<Customer> customer = dbContext.Customers.ToList();
                foreach (var i in customer)
                {
                    Console.WriteLine($"Customer id : {i.Id}, Customer full name : {i.FullName}, customer email : {i.Email}, customer phone no : {i.PhoneNumber}, customer date of birth : {i.DateOfBirth}, customer address : {i.Address}, customer created date : {i.CreatedDate}");
                }
            }
        }
    }
}
