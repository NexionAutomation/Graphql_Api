using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class ProjectPhase
    {
        public ProjectPhase()
        {
            LeadJournals = new HashSet<LeadJournal>();
            Leads = new HashSet<Lead>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }

        public virtual ICollection<LeadJournal> LeadJournals { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
