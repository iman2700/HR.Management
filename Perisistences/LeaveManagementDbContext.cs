using Domain;
using Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perisistences
{
    public class LeaveManagementDbContext : DbContext
    {
        public LeaveManagementDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet <LeaveRequest> LeaveRequests { get; set; }
        public DbSet <LeaveType> LeaveTypes { get;set; }
        public DbSet <LeaveAllocation> LeaveAllocations { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(LeaveManagementDbContext).Assembly);
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseDomainEntitiy>()) 
            {
                entry.Entity.LastModifedDate = DateTime.Now;
                if (entry.State == EntityState.Added) 
                {
                entry.Entity.DateCreated= DateTime.Now;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
