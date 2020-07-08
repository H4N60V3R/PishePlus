using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public Guid AdminGuid { get; set; }
        public int UserId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual User User { get; set; }
    }
}
