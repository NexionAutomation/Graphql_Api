using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LempLeaveSetting
    {
        public int LsetId { get; set; }
        public string AnnualLeave { get; set; }
        public string CarryForward { get; set; }
        public DateTime? CreatedBy { get; set; }
        public string CreatedOn { get; set; }
    }
}
