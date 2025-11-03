using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HotelDbContext _dbContext;

        public EmployeeService(HotelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IEnumerable<Employee>> GetAll()
        {
            return await _dbContext.Employees
              .Include(h => h.Hotel)
              .ToListAsync();
        }
        public async Task<Employee?> GetById(int id)
        {
            return await _dbContext.Employees
              .Include(h => h.Hotel)
              .FirstOrDefaultAsync(h => h.Id == id);
        }
        public async Task<Employee> Add(AddEmployee employee)
        {
            var addEmployee = new Employee
            {
               HotelId = employee.HotelId,
               FullName= employee.FullName,
               Role = employee.Role,
               Email= employee.Email,
            };
            _dbContext.Employees.Add(addEmployee);
            int result = await _dbContext.SaveChangesAsync();
            return addEmployee;
        }
        public async Task<Employee?> Update(int id, UpdateEmployee employee)
        {
            var employees = await _dbContext.Employees.FindAsync(id);
            if (employees == null)
                return null;
            else
            {
                if (employee.HotelId.HasValue)
                    employees.HotelId = employee.HotelId.Value;
                if (!string.IsNullOrWhiteSpace(employee.FullName))
                    employees.FullName = employee.FullName;
                if(employee.Role != null)
                    employees.Role = employee.Role;
                if (employee.Email != null)
                    employee.Email = employee.Email;
            }
            await _dbContext.SaveChangesAsync();
            return employees;
        }
        public async Task<bool> Delete(int id)
        {
            var employee = await _dbContext.Employees.FindAsync(id);
            if (employee == null)
                return false;
            _dbContext.Employees.Remove(employee);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
