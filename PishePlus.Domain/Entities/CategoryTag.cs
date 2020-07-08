using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class CategoryTag
    {
        public int CategoryTagId { get; set; }
        public Guid CategoryTagGuid { get; set; }
        public int CategoryId { get; set; }
        public int TagId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
