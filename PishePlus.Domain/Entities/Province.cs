using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Province
    {
        public Province()
        {
            City = new HashSet<City>();
        }

        public int ProvinceId { get; set; }
        public Guid ProvinceGuid { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<City> City { get; set; }
    }
}
