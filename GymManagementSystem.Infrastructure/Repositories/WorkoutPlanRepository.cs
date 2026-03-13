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
    public class WorkoutPlanRepository:IWorkoutPlanRepository
    {
        private readonly GymDbContext _context;
        public WorkoutPlanRepository(GymDbContext context)
        {
            _context = context;
        }

        public async Task<List<WorkoutPlan>> GetAllAsync()
        {
            return await _context.WorkoutPlans.ToListAsync();
        }
        public async Task<WorkoutPlan> GetByIdAsync(int id)
        {
            return await _context.WorkoutPlans.FindAsync(id);
        }
        public async Task AddAsync(WorkoutPlan workoutplan)
        {
            _context.WorkoutPlans.Add(workoutplan);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(WorkoutPlan workoutPlan)
        {
            _context.WorkoutPlans.Update(workoutPlan);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var workoutplan = await _context.WorkoutPlans.FindAsync(id);
            if (workoutplan != null)
            {
                _context.WorkoutPlans.Remove(workoutplan);
                await _context.SaveChangesAsync();
            }
        }

    }
}
