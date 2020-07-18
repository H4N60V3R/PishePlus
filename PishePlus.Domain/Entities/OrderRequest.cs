using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class OrderRequest
    {
        public OrderRequest()
        {
            ChatMessage = new HashSet<ChatMessage>();
        }

        public int OrderRequestId { get; set; }
        public Guid OrderRequestGuid { get; set; }
        public int ContractorId { get; set; }
        public int OrderId { get; set; }
        public int StateCodeId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public long OfferedPrice { get; set; }
        public bool IsAllow { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual Order Order { get; set; }
        public virtual Code StateCode { get; set; }
        public virtual ICollection<ChatMessage> ChatMessage { get; set; }
    }
}
