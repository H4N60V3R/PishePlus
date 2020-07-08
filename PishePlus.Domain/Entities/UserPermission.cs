using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class UserPermission
    {
        public int UserPermissionId { get; set; }
        public Guid UserPermissionGuid { get; set; }
        public int PermissionId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual User User { get; set; }
    }
}
