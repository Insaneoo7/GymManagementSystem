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
    internal class TrainerRepository:ITrainerRepository
    {
        private readonly GymDbContext _context;
        public TrainerRepository(GymDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(Trainer trainer)
        {
          
        }

        public Task DeleteAsync(int id)
        {
           
        }

        public Task<List<Trainer>> GetAllAsync()
        {
            
        }

        public Task<Trainer> GetByIdAsync(int id)
        {
            
        }

        public Task UpdateAsync(Trainer trainer)
        {
           
        }
    }
}
