using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            CategoryTag = new HashSet<CategoryTag>();
            PostTag = new HashSet<PostTag>();
        }

        public int TagId { get; set; }
        public Guid TagGuid { get; set; }
        public string Name { get; set; }
        public int Usage { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CategoryTag> CategoryTag { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
