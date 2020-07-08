using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class CodeGroup
    {
        public CodeGroup()
        {
            Code = new HashSet<Code>();
        }

        public int CodeGroupId { get; set; }
        public Guid CodeGroupGuid { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Code> Code { get; set; }
    }
}
