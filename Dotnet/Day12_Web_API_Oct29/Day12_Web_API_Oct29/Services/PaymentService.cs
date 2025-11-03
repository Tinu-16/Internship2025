using Day12_Web_API_Oct29.Interface;
using Day12_Web_API_Oct29.Models;
using Day12_Web_API_Oct29.Request;
using Microsoft.EntityFrameworkCore;

namespace Day12_Web_API_Oct29.Services
{
    public class PaymentService :IPaymentService
    {
        private readonly HotelDbContext _dbContext;

        public PaymentService(HotelDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<IEnumerable<Payment>> GetAll()
        {
            return await _dbContext.Payments
               .Include(h => h.Booking)
               .ToListAsync();
        }
        public async Task<Payment?> GetById(int id)
        {
            return await _dbContext.Payments
             .Include(h => h.Booking)
             .FirstOrDefaultAsync(h => h.Id == id);
        }
        public async Task<Payment> Add(AddPayment payment)
        {
            var addPayment = new Payment
            {
                BookingId = payment.BookingId,
                Amount = payment.Amount,
                Method = payment.Method,
                Status = payment.Status
            };
            _dbContext.Payments.Add(addPayment);
            int result = await _dbContext.SaveChangesAsync();
            return addPayment;
        }
        public async Task<Payment?> Update(int id, UpdatePayment payment)
        {
            var payments = await _dbContext.Payments.FindAsync(id);
            if (payments == null)
                return null;
            else
            {
                if (payment.BookingId.HasValue)
                    payments.BookingId = payment.BookingId.Value;
                if(payment.Amount.HasValue)
                    payments.Amount = payment.Amount.Value;
                if (payment.Method.HasValue)
                    payments.Method = payment.Method.Value; 
                if (payment.Status.HasValue)
                    payments.Status = payment.Status.Value;
            }
            await _dbContext.SaveChangesAsync();
            return payments;
        }
        public async Task<bool> Delete(int id)
        {
            var payment = await _dbContext.Payments.FindAsync(id);
            if (payment == null)
                return false;
            _dbContext.Payments.Remove(payment);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}
