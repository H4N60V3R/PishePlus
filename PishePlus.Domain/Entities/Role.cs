using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Role
    {
        public Role()
        {
            RolePermission = new HashSet<RolePermission>();
            User = new HashSet<User>();
        }

        public int RoleId { get; set; }
        public Guid RoleGuid { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<RolePermission> RolePermission { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
