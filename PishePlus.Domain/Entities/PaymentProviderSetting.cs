using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PaymentProviderSetting
    {
        public PaymentProviderSetting()
        {
            Payment = new HashSet<Payment>();
        }

        public int PaymentProviderSettingId { get; set; }
        public Guid PaymentProviderSettingGuid { get; set; }
        public int PaymentProviderId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Apikey { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual PaymentProvider PaymentProvider { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
