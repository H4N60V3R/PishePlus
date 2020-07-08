using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Category
    {
        public Category()
        {
            CategoryTag = new HashSet<CategoryTag>();
            ContractorCategory = new HashSet<ContractorCategory>();
            InverseParentCategory = new HashSet<Category>();
            Order = new HashSet<Order>();
            PostCategory = new HashSet<PostCategory>();
        }

        public int CategoryId { get; set; }
        public Guid CategoryGuid { get; set; }
        public int? ParentCategoryId { get; set; }
        public int? CoverDocumentId { get; set; }
        public int? SecondPageCoverDocumentId { get; set; }
        public int? ActiveIconDocumentId { get; set; }
        public int? InactiveIconDocumentId { get; set; }
        public int? QuadMenuDocumentId { get; set; }
        public string DisplayName { get; set; }
        public string Abstract { get; set; }
        public string Description { get; set; }
        public int Sort { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document ActiveIconDocument { get; set; }
        public virtual Document CoverDocument { get; set; }
        public virtual Document InactiveIconDocument { get; set; }
        public virtual Category ParentCategory { get; set; }
        public virtual Document QuadMenuDocument { get; set; }
        public virtual Document SecondPageCoverDocument { get; set; }
        public virtual ICollection<CategoryTag> CategoryTag { get; set; }
        public virtual ICollection<ContractorCategory> ContractorCategory { get; set; }
        public virtual ICollection<Category> InverseParentCategory { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<PostCategory> PostCategory { get; set; }
    }
}
