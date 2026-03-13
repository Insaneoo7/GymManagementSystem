using GymManagementSystem.Domain.Entities;
using GymManagementSystem.Domain.Interfaces;
using GymManagementSystem.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Infrastructure.Repositories
{
    public class PaymentRepository:IPaymentRepository
    {
        private readonly GymDbContext _context;
        public PaymentRepository(GymDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Payment payment)
        {
           
        }

        public Task DeleteAsync(int id)
        {
          
        }

        public Task<List<Payment>> GetAllAsync()
        {
           
        }

        public Task<Payment> GetByIdAsync(int id)
        {
           
        }

        public Task UpdateAsync(Payment payment)
        {
           
        }
    }
}
