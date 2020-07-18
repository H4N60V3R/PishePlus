using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public Guid ApplicationGuid { get; set; }
        public int? DocumentId { get; set; }
        public string Name { get; set; }
        public string VersionCode { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document Document { get; set; }
    }
}
