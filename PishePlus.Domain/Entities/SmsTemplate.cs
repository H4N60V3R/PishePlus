using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class SmsTemplate
    {
        public SmsTemplate()
        {
            SmsResponse = new HashSet<SmsResponse>();
        }

        public int SmsTemplateId { get; set; }
        public Guid SmsTemplateGuid { get; set; }
        public int SmsProviderSettingId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual SmsProviderSetting SmsProviderSetting { get; set; }
        public virtual ICollection<SmsResponse> SmsResponse { get; set; }
    }
}
