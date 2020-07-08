using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class SmsResponse
    {
        public int SmsResponseId { get; set; }
        public Guid SmsResponseGuid { get; set; }
        public int? SmsTemplateId { get; set; }
        public int UserId { get; set; }
        public int Status { get; set; }
        public string StatusText { get; set; }
        public string Sender { get; set; }
        public string Receptor { get; set; }
        public string Token { get; set; }
        public string Token1 { get; set; }
        public string Token2 { get; set; }
        public string Message { get; set; }
        public long Cost { get; set; }
        public bool IsDelete { get; set; }
        public DateTime SentDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SmsTemplate SmsTemplate { get; set; }
        public virtual User User { get; set; }
    }
}
