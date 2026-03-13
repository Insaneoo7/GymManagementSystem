using GymManagementSystem.Domain.Entities;
using GymManagementSystem.Domain.Interfaces;
using GymManagementSystem.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
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
        public async Task<List<DietPlan>> GetAllAsync()
        {
            return await _context.DietPlans.ToListAsync();
        }
        public async Task<DietPlan> GetByIdAsync(int id)
        {
            return await _context.DietPlans.FindAsync(id);
        }

        public async Task AddAsync(DietPlan dietPlan)
        {
          await _context.DietPlans.AddAsync(dietPlan);
            await _context.SaveChangesAsync();
            
        }
        public async Task UpdateAsync(DietPlan dietPlan)
        {
           _context.DietPlans.Update(dietPlan);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var dietplan = await _context.DietPlans.FindAsync(id);
            if (dietplan != null)
            {
                _context.DietPlans.Remove(dietplan);
                await _context.SaveChangesAsync();
            }
        }

       
    }
}

