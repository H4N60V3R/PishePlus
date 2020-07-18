using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Document
    {
        public Document()
        {
            Advertisement = new HashSet<Advertisement>();
            Application = new HashSet<Application>();
            CategoryActiveIconDocument = new HashSet<Category>();
            CategoryCoverDocument = new HashSet<Category>();
            CategoryInactiveIconDocument = new HashSet<Category>();
            CategoryQuadMenuDocument = new HashSet<Category>();
            CategorySecondPageCoverDocument = new HashSet<Category>();
            ContractorDocument = new HashSet<ContractorDocument>();
            Post = new HashSet<Post>();
            User = new HashSet<User>();
        }

        public int DocumentId { get; set; }
        public Guid DocumentGuid { get; set; }
        public int TypeCodeId { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Code TypeCode { get; set; }
        public virtual ICollection<Advertisement> Advertisement { get; set; }
        public virtual ICollection<Application> Application { get; set; }
        public virtual ICollection<Category> CategoryActiveIconDocument { get; set; }
        public virtual ICollection<Category> CategoryCoverDocument { get; set; }
        public virtual ICollection<Category> CategoryInactiveIconDocument { get; set; }
        public virtual ICollection<Category> CategoryQuadMenuDocument { get; set; }
        public virtual ICollection<Category> CategorySecondPageCoverDocument { get; set; }
        public virtual ICollection<ContractorDocument> ContractorDocument { get; set; }
        public virtual ICollection<Post> Post { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
