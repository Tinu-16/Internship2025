using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetAll();
        Task<Customer?> GetById(int id);
        Task<Customer> Add(AddCustomer customer);
        Task<Customer?> Update(int id, UpdateCustomer customer);
        Task<bool> Delete(int id);
    }
}
