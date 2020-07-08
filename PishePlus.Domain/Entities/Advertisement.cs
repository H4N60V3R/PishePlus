using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Advertisement
    {
        public int AdvertisementId { get; set; }
        public Guid AdvertisementGuid { get; set; }
        public int DocumentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document Document { get; set; }
    }
}
