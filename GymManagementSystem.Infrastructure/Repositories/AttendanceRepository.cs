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
    public class AttendanceRepository:IAttendanceRepository
    {
        private readonly GymDbContext _context;

        public AttendanceRepository(GymDbContext context)
        {
            _context = context;
        }
        

        public async Task<List<Attendance>> GetAllAsync()
        {
            return await _context.Attendances.ToListAsync();
        }

        public async Task<Attendance> GetByIdAsync(int id)
        {
            return await _context.Attendances.FindAsync(id);
        }

        public async Task AddAsync(Attendance attendance)
        {
           await _context.Attendances.AddAsync(attendance);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Attendance attendance)
        {
           _context.Attendances.Update(attendance);
           await _context.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            var attendance = await _context.Attendances.FindAsync(id);
            if (attendance != null)
            {
                _context.Attendances.Remove(attendance);
                await _context.SaveChangesAsync();
            }
        }
    }
}
