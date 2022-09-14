using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Lead
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int AccountId { get; set; }
        public decimal Value { get; set; }
        public string Currency { get; set; }
        public int Status { get; set; }
        public int Phase { get; set; }
        public string Remarks { get; set; }
        public int Owner { get; set; }
        public DateTime CloseDate { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime? LastUpdated { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsFunded { get; set; }
        public double? Probability { get; set; }
        public string Source { get; set; }
        public bool MustWin { get; set; }

        public string LeadTrackId { get; set; }
        public int? CompanyId { get; set; }
        public bool? IsDeleted { get; set; }
        public string Ramaster { get; set; }
        public decimal? Ravalue { get; set; }

        public virtual Account Account { get; set; }
        public virtual User OwnerNavigation { get; set; }
        public virtual ProjectPhase PhaseNavigation { get; set; }
        public virtual Status StatusNavigation { get; set; }
    }
}
