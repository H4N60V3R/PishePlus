using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class ContractorDiscount
    {
        public int ContractorDiscountId { get; set; }
        public Guid ContractorDiscountGuid { get; set; }
        public int ContractorId { get; set; }
        public int PublicDiscountId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsDelete { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual PublicDiscount PublicDiscount { get; set; }
    }
}
