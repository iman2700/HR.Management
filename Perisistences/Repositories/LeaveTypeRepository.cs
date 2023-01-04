using Application.Contracts.Persistence;
using Domain;
using Perisistences;
using Perisistences.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace  Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;

        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
 