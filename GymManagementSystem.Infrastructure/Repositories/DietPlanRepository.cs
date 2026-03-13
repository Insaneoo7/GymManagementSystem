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
    public class DietPlanRepository:IDietPlanRepository
    {
        private readonly GymDbContext _context;
        public DietPlanRepository(GymDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(DietPlan dietPlan)
        {
            
        }

        public Task DeleteAsync(int id)
        {
           
        }

        public Task<List<DietPlan>> GetAllAsync()
        {
            
        }

        public Task<DietPlan> GetByIdAsyncAsync(int id)
        {
            
        }

        public Task UpdateAsync(DietPlan dietPlan)
        {
           
        }
    }
}
