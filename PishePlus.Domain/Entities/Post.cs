using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Post
    {
        public Post()
        {
            PostCategory = new HashSet<PostCategory>();
            PostComment = new HashSet<PostComment>();
            PostTag = new HashSet<PostTag>();
        }

        public int PostId { get; set; }
        public Guid PostGuid { get; set; }
        public int UserId { get; set; }
        public int DocumentId { get; set; }
        public int ViewCount { get; set; }
        public int LikeCount { get; set; }
        public string Title { get; set; }
        public string Abstract { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }
        public bool IsSuggested { get; set; }
        public bool IsInSlider { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Document Document { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PostCategory> PostCategory { get; set; }
        public virtual ICollection<PostComment> PostComment { get; set; }
        public virtual ICollection<PostTag> PostTag { get; set; }
    }
}
