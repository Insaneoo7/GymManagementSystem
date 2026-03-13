using GymManagementSystem.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Infrastructure.Data
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options)
           : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }

        public DbSet<Trainer> Trainers { get; set; }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<WorkoutPlan> WorkoutPlans { get; set; }

        public DbSet<DietPlan> DietPlans { get; set; }

        public DbSet<Attendance> Attendances { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasPrecision(18, 2);
            modelBuilder.Entity<Member>()
       .HasOne(m => m.Trainer)
       .WithMany()
       .HasForeignKey(m => m.TrainerId)
       .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DietPlan>()
                .HasOne(d => d.Trainer)
                .WithMany()
                .HasForeignKey(d => d.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<WorkoutPlan>()
                .HasOne(w => w.Trainer)
                .WithMany()
                .HasForeignKey(w => w.TrainerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
