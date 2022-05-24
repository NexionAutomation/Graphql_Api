using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class AuditTrailLead
    {
        public int Id { get; set; }
        public int KeyFieldId { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public string DataModel { get; set; }
        public string Changes { get; set; }
        public string ValueBefore { get; set; }
        public string ValueAfter { get; set; }
    }
}
