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
    public class TrainerRepository:ITrainerRepository
    {
        private readonly GymDbContext _context;
        public TrainerRepository(GymDbContext context)
        {
            _context = context;
        }
        public async Task<List<Trainer>> GetAllAsync()
        {
            return await _context.Trainers.ToListAsync();
        }
        public async Task<Trainer> GetByIdAsync(int id)
        {
            return await _context.Trainers.FindAsync(id);
        }
        public async Task AddAsync(Trainer trainer)
        {
            _context.Trainers.Add(trainer);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Trainer trainer)
        {
            _context.Trainers.Update(trainer);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var trainer = await _context.Trainers.FindAsync(id);
            if (trainer != null)
            {
                _context.Trainers.Remove(trainer);
                await _context.SaveChangesAsync();
            }
        }


    }
}
