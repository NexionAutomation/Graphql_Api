using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Status
    {
        public Status()
        {
            Leads = new HashSet<Lead>();
        }

        public int Id { get; set; }
        public string Status1 { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        public bool? Active { get; set; }

        public virtual ICollection<Lead> Leads { get; set; }
    }
}
