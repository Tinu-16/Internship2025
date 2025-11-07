using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAll();
        Task<Employee?> GetById(int id);
        Task<Employee> Add(AddEmployee employee);
        Task<Employee?> Update(int id, UpdateEmployee employee);
        Task<bool> Delete(int id);
    }
}
