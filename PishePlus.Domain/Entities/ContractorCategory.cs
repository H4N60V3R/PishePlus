using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class ContractorCategory
    {
        public int ContractorCategoryId { get; set; }
        public Guid ContractorCategoryGuid { get; set; }
        public int ContractorId { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Contractor Contractor { get; set; }
    }
}
