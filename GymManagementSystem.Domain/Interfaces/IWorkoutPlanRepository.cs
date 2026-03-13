using GymManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Domain.Interfaces
{
    public interface IWorkoutPlanRepository
    {
        Task<List<WorkoutPlan>> GetAllAsync();
        Task<WorkoutPlan> GetByIdAsync(int id);
        Task AddAsync(WorkoutPlan workoutPlan);
        Task UpdateAsync(WorkoutPlan workoutPlan);
        Task DeleteAsync(int id);
    }
}
