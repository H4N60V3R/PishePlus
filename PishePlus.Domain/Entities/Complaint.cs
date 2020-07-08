using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Complaint
    {
        public int ComplaintId { get; set; }
        public Guid ComplaintGuid { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual User User { get; set; }
    }
}
