using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Comment
    {
        public Comment()
        {
            PostComment = new HashSet<PostComment>();
        }

        public int CommentId { get; set; }
        public Guid CommentGuid { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<PostComment> PostComment { get; set; }
    }
}
