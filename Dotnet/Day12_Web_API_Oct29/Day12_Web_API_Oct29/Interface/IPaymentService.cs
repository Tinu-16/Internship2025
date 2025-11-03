using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;

namespace Day12_Web_API_Oct29.Interface
{
    public interface IPaymentService
    {
        Task<IEnumerable<Payment>> GetAll();
        Task<Payment?> GetById(int id);
        Task<Payment> Add(AddPayment payment);
        Task<Payment?> Update(int id, UpdatePayment payment);
        Task<bool> Delete(int id);
    }
}
