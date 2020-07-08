using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class PaymentProvider
    {
        public PaymentProvider()
        {
            PaymentProviderSetting = new HashSet<PaymentProviderSetting>();
        }

        public int PaymentProviderId { get; set; }
        public Guid PaymentProviderGuid { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<PaymentProviderSetting> PaymentProviderSetting { get; set; }
    }
}
