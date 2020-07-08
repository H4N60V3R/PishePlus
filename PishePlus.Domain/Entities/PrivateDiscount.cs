using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PrivateDiscount
    {
        public int PrivateDiscountId { get; set; }
        public Guid PrivateDiscountGuid { get; set; }
        public int ContractorId { get; set; }
        public int TypeCodeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int MaximumUsesNumber { get; set; }
        public int NumberUsed { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual Code TypeCode { get; set; }
    }
}
