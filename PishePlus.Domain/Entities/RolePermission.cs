using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class RolePermission
    {
        public int RolePermissionId { get; set; }
        public Guid RolePermissionGuid { get; set; }
        public int PermissionId { get; set; }
        public int RoleId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Permission Permission { get; set; }
        public virtual Role Role { get; set; }
    }
}
