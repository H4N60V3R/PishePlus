using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Order
    {
        public Order()
        {
            OrderRequest = new HashSet<OrderRequest>();
        }

        public int OrderId { get; set; }
        public Guid OrderGuid { get; set; }
        public int ClientId { get; set; }
        public int? ContractorId { get; set; }
        public int CategoryId { get; set; }
        public int StateCodeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public double? Rate { get; set; }
        public int? Cost { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? DeadlineDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual Client Client { get; set; }
        public virtual Contractor Contractor { get; set; }
        public virtual Code StateCode { get; set; }
        public virtual ICollection<OrderRequest> OrderRequest { get; set; }
    }
}
