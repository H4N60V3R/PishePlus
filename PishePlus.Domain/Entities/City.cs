using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class City
    {
        public City()
        {
            Client = new HashSet<Client>();
            Contractor = new HashSet<Contractor>();
        }

        public int CityId { get; set; }
        public Guid CityGuid { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Province Province { get; set; }
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Contractor> Contractor { get; set; }
    }
}
