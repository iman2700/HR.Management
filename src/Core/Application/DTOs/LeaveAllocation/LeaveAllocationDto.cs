using Application.DTOs.Common;
using Application.DTOs.LeaveType;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveAllocation
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }

        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
