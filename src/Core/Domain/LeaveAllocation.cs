using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class LeaveAllocation : BaseDomainEntitiy
    {
         
        public int NumberOfDays { get; set; }
        public DateTime DateCreated { get; set; }
      //  [ForeignKey("EmployeeId")]
        //public Employee Employee { get; set; }
        //public string EmployeeId { get; set; }
    //    [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}
