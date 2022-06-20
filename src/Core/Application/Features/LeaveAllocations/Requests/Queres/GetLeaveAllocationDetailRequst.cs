using Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveAllocations.Requests.Queres
{
    public class GetLeaveAllocationDetailRequst:IRequest<LeaveAllocationDto>
    {
        public int Id{ get; set; }
    }
}
