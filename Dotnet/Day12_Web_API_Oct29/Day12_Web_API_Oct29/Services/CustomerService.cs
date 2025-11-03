using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly HotelDbContext _dbContext;

        public CustomerService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _dbContext.Customers
               .Include(h => h.Bookings)
               .ToListAsync();
        }
        public async Task<Customer?> GetById(int id)
        {
            return await _dbContext.Customers
               .Include(h => h.Bookings)
               .FirstOrDefaultAsync(a => a.Id == id);
        }
        public async Task<Customer> Add(AddCustomer customer)
        {
            var addCustomer = new Customer
            {
                FullName = customer.FullName,
                Email=customer.Email,
                PhoneNumber = customer.PhoneNumber,
                IdProofNumber = customer.IdProofNumber
            };
            _dbContext.Customers.Add(addCustomer);
            int result = await _dbContext.SaveChangesAsync();
            return addCustomer;
        }
        public async Task<Customer?> Update(int id, UpdateCustomer customer)
        {
            var existingCustomer = await _dbContext.Customers.FindAsync(id);
            if (existingCustomer == null)
                return null;
            else
            {
                if (!string.IsNullOrWhiteSpace(customer.FullName))
                    existingCustomer.FullName = customer.FullName;
                if (!string.IsNullOrWhiteSpace(customer.Email))
                    existingCustomer.Email = customer.Email;
                if (!string.IsNullOrWhiteSpace(customer.PhoneNumber))
                    existingCustomer.PhoneNumber = customer.PhoneNumber;
                if (!string.IsNullOrWhiteSpace(customer.IdProofNumber))
                    existingCustomer.IdProofNumber = customer.IdProofNumber;
            }
            await _dbContext.SaveChangesAsync();
            return existingCustomer;

        }
        public async Task<bool> Delete(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null) 
                return false;
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
