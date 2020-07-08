using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PublicDiscount
    {
        public PublicDiscount()
        {
            ContractorDiscount = new HashSet<ContractorDiscount>();
        }

        public int PublicDiscountId { get; set; }
        public Guid PublicDiscountGuid { get; set; }
        public int TypeCodeId { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }

        public virtual Code TypeCode { get; set; }
        public virtual ICollection<ContractorDiscount> ContractorDiscount { get; set; }
    }
}
