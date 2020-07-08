using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class ChatMessage
    {
        public int ChatMessageId { get; set; }
        public Guid ChatMessageGuid { get; set; }
        public int OrderRequestId { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public bool IsSeen { get; set; }
        public bool IsModified { get; set; }
        public bool IsDelete { get; set; }
        public DateTime SentAt { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual OrderRequest OrderRequest { get; set; }
        public virtual User User { get; set; }
    }
}
