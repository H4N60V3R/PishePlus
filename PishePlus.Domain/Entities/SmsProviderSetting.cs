using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class SmsProviderSetting
    {
        public SmsProviderSetting()
        {
            SmsProviderSettingNumber = new HashSet<SmsProviderSettingNumber>();
            SmsTemplate = new HashSet<SmsTemplate>();
        }

        public int SmsProviderSettingId { get; set; }
        public Guid SmsProviderSettingGuid { get; set; }
        public int SmsProviderId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Apikey { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SmsProvider SmsProvider { get; set; }
        public virtual ICollection<SmsProviderSettingNumber> SmsProviderSettingNumber { get; set; }
        public virtual ICollection<SmsTemplate> SmsTemplate { get; set; }
    }
}
