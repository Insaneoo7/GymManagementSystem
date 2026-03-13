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
    public class MemberRepository:IMemberRepository
    {
        private readonly GymDbContext _context;

        public MemberRepository(GymDbContext context)
        {
            _context = context;
        }

        

        public async Task<List<Member>> GetAllAsync()
        {
            return await _context.Members.ToListAsync();
        }
        public async Task<Member> GetByIdAsync(int id)
        {
            return await _context.Members.FindAsync(id);
        }

        public async Task AddAsync(Member member)
        {
            await _context.Members.AddAsync(member);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Member member)
        {
           _context.Members.Update(member);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var member= await _context.Members.FindAsync(id);
            if (member != null)
            {
                _context.Members.Remove(member);
                await _context.SaveChangesAsync();
            }
        }
    }
}

