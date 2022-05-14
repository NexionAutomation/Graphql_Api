using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmDashboard1
    {
        public int? ToTalPo { get; set; }
        public int? TotalPoToday { get; set; }
        public double TotalPoAmount { get; set; }
        public double TotalPoTodayAmount { get; set; }
        public int TotalUsers { get; set; }
    }
}
