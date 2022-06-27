using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequstApprovalDto:BaseDto
    {
        public bool Approved { get; set; }
    }
}
