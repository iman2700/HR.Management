using Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand:IRequest
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
