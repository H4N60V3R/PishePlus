using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public Guid PaymentGuid { get; set; }
        public int PaymentProviderSettingId { get; set; }
        public int ContractorId { get; set; }
        public int Cost { get; set; }
        public int Discount { get; set; }
        public long? TrackingToken { get; set; }
        public bool IsSuccessful { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual Contractor Contractor { get; set; }
        public virtual PaymentProviderSetting PaymentProviderSetting { get; set; }
    }
}
