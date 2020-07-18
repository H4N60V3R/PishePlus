using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Code
    {
        public Code()
        {
            ContactUs = new HashSet<ContactUs>();
            Contractor = new HashSet<Contractor>();
            ContractorDocument = new HashSet<ContractorDocument>();
            Document = new HashSet<Document>();
            Order = new HashSet<Order>();
            OrderRequest = new HashSet<OrderRequest>();
            Post = new HashSet<Post>();
            PrivateDiscount = new HashSet<PrivateDiscount>();
            PublicDiscount = new HashSet<PublicDiscount>();
            Token = new HashSet<Token>();
            Transaction = new HashSet<Transaction>();
            User = new HashSet<User>();
        }

        public int CodeId { get; set; }
        public Guid CodeGuid { get; set; }
        public int CodeGroupId { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual CodeGroup CodeGroup { get; set; }
        public virtual ICollection<ContactUs> ContactUs { get; set; }
        public virtual ICollection<Contractor> Contractor { get; set; }
        public virtual ICollection<ContractorDocument> ContractorDocument { get; set; }
        public virtual ICollection<Document> Document { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<OrderRequest> OrderRequest { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<PrivateDiscount> PrivateDiscount { get; set; }
        public virtual ICollection<PublicDiscount> PublicDiscount { get; set; }
        public virtual ICollection<Token> Token { get; set; }
        public virtual ICollection<Transaction> Transaction { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
