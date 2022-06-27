using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        ILeaveAllocationRepository LeaveAllocationRepository { get; }
        ILeaveRequestRepository LeaveRequestRepository { get; }
        ILeaveTypeRepository LeaveTypeRepository { get; }
        Task Save();
    }
}
