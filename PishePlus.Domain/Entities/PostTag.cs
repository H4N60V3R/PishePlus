using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PostTag
    {
        public int PostTagId { get; set; }
        public Guid PostTagGuid { get; set; }
        public int PostId { get; set; }
        public int TagId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
