using Application.DTOs.Common;
using Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveRequest
{
    public class LeaveRequstListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequsted { get; set; }
        public bool? Approved { get; set; }

    }
}
