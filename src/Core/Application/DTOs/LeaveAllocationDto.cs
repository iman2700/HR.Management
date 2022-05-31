using Application.DTOs.Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs
{
    public class LeaveAllocationDto: BaseDto
    {
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
  
        public LeaveTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
