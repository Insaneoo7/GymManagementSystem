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
    public class WorkoutPlanRepository:IWorkoutPlanRepository
    {
        private readonly GymDbContext _context;
        public WorkoutPlanRepository(GymDbContext context)
        {
            _context = context;
        }

        public Task AddAsync(WorkoutPlan workoutPlan)
        {
            
        }

        public Task DeleteAsync(int id)
        {
           
        }

        public Task<List<WorkoutPlan>> GetAllAsync()
        {
            
        }

        public Task<WorkoutPlan> GetByIdAsync(int id)
        {
            
        }

        public Task UpdateAsync(WorkoutPlan workoutPlan)
        {
           
        }
    }
}
