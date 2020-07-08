using System;
using System.Collections.Generic;

namespace PishePlus.Domain.Entities
{
    public partial class Suggestion
    {
        public int SuggestionId { get; set; }
        public Guid SuggestionGuid { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public virtual User User { get; set; }
    }
}
