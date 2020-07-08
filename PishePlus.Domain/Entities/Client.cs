using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Client
    {
        public Client()
        {
            Order = new HashSet<Order>();
        }

        public int ClientId { get; set; }
        public Guid ClientGuid { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
