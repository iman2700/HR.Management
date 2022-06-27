using Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Persistence.Contracts
{
    public interface ILeaveRequestRepository:IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDeatail(int Id);
        Task<List<LeaveRequest>>GetLeaveRequestWithDeatail();
        Task ChangeApprovalStatus(LeaveRequest leaveRequest,bool? ApproveStatus);
    }
}
