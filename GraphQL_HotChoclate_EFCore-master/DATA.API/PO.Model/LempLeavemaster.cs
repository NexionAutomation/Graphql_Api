using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LempLeavemaster
    {
        public int LmId { get; set; }
        public string LeaveType { get; set; }
        public DateTime? CreatedBy { get; set; }
        public string CreatedOn { get; set; }
        public int? Alloted { get; set; }
        public string Color { get; set; }
    }
}
