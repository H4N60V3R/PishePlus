using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Contractor
    {
        public Contractor()
        {
            ContractorCategory = new HashSet<ContractorCategory>();
            ContractorDiscount = new HashSet<ContractorDiscount>();
            ContractorDocument = new HashSet<ContractorDocument>();
            Order = new HashSet<Order>();
            OrderRequest = new HashSet<OrderRequest>();
            Payment = new HashSet<Payment>();
            PrivateDiscount = new HashSet<PrivateDiscount>();
        }

        public int ContractorId { get; set; }
        public Guid ContractorGuid { get; set; }
        public int UserId { get; set; }
        public int BusinessTypeCodeId { get; set; }
        public int CityId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int Credit { get; set; }
        public double? AverageRate { get; set; }
        public string Address { get; set; }
        public string AboutMe { get; set; }
        public string Telephone { get; set; }
        public string Website { get; set; }
        public string Instagram { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Code BusinessTypeCode { get; set; }
        public virtual City City { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<ContractorCategory> ContractorCategory { get; set; }
        public virtual ICollection<ContractorDiscount> ContractorDiscount { get; set; }
        public virtual ICollection<ContractorDocument> ContractorDocument { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<OrderRequest> OrderRequest { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
        public virtual ICollection<PrivateDiscount> PrivateDiscount { get; set; }
    }
}
