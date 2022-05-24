using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class LeadJournal
    {
        public int ProjectId { get; set; }
        public string Status { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        public int? Phase { get; set; }
        public bool Active { get; set; }

        public virtual ProjectPhase PhaseNavigation { get; set; }
    }
}
