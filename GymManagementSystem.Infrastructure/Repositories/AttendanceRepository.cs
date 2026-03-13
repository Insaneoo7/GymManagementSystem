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
    public class AttendanceRepository:IAttendanceRepository
    {
        private readonly GymDbContext _context;

        public AttendanceRepository(GymDbContext context)
        {
            _context = context;
        }
        

        public Task<List<Attendance>> GetAllAsync()
        {
            
        }

        public Task<Attendance> GetByIdAsync(int id)
        {
            
        }

        public Task AddAsync(Attendance attendance)
        {
           
        }

        public Task UpdateAsync(Attendance attendance)
        {
            
        }

        public Task DeleteAsync(int id)
        {
            
        }
    }
}
