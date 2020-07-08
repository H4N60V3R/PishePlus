using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class SmsProviderSettingNumber
    {
        public int SmsProviderSettingNumberId { get; set; }
        public Guid SmsProviderSettingNumberGuid { get; set; }
        public int SmsProviderSettingId { get; set; }
        public string Value { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SmsProviderSetting SmsProviderSetting { get; set; }
    }
}
