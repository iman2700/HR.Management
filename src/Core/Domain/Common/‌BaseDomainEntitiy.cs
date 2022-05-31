using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
  public abstract class BaseDomainEntitiy
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModifedDate { get; set; }
        public string LastModifedBy { get; set; }
    }
}
