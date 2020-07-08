using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class SmsProvider
    {
        public SmsProvider()
        {
            SmsProviderSetting = new HashSet<SmsProviderSetting>();
        }

        public int SmsProviderId { get; set; }
        public Guid SmsProviderGuid { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SmsProviderSetting> SmsProviderSetting { get; set; }
    }
}
