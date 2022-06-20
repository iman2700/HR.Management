using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.LeaveType.Requests.Cammands
{
    public class DeleteLeaveTypeCommand : IRequest
    {
        public int Id { get; set; }
    }
}
