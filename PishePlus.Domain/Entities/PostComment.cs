using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PostComment
    {
        public int PostCommentId { get; set; }
        public Guid PostCommentGuid { get; set; }
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public bool IsAccept { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Post Post { get; set; }
    }
}
