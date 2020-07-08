using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Token
    {
        public int TokenId { get; set; }
        public Guid TokenGuid { get; set; }
        public int UserId { get; set; }
        public int RoleCodeId { get; set; }
        public int Value { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Code RoleCode { get; set; }
        public virtual User User { get; set; }
    }
}
