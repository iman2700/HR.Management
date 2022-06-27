using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto
    {
        public int LeaveTypeId { get; set; }
        public int NumberOfDay { get; set; }
        public int Preiod { get; set; }
    }
}
