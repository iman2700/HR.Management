using Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class LeaveRequstListDto: BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequsted { get; set; }
        public bool? Approved { get; set; }

    }
}
