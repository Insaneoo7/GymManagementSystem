using GymManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Domain.Interfaces
{
    public interface ITrainerRepository
    {
        Task<List<Trainer>> GetAllAsync();

        Task<Trainer> GetByIdAsync(int id);

        Task AddAsync(Trainer trainer);

        Task UpdateAsync(Trainer trainer);

        Task DeleteAsync(int id);
    }
}
