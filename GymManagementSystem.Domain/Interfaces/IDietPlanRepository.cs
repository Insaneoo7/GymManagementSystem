using GymManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Domain.Interfaces
{
    public interface IDietPlanRepository
    {
        Task<List<DietPlan>> GetAllAsync();
        Task<DietPlan> GetByIdAsync(int id);
        Task AddAsync (DietPlan dietPlan);
        Task UpdateAsync (DietPlan dietPlan);
        Task DeleteAsync (int id);
    }
}
