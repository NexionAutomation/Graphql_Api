using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TransporttypeVsRate1
    {
        public int Rid { get; set; }
        public int? TransportTypeId { get; set; }
        public double? Rate { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
    }
}
