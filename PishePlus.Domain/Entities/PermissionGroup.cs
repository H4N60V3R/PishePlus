using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PermissionGroup
    {
        public PermissionGroup()
        {
            Permission = new HashSet<Permission>();
        }

        public int PermissionGroupId { get; set; }
        public Guid PermissionGroupGuid { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Permission> Permission { get; set; }
    }
}
