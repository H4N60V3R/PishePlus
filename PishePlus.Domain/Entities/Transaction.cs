using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public Guid TransactionGuid { get; set; }
        public int UserId { get; set; }
        public int TypeCodeId { get; set; }
        public long Cost { get; set; }
        public string Serial { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Code TypeCode { get; set; }
    }
}
