using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class LeaveType: BaseDomainEntitiy
    {
        
        public string Name { get; set; }
        public int DefaultDays { get; set; }
         
    }
}
