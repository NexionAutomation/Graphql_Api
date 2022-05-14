using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class VwDashBoard1
    {
        public int? Year { get; set; }
        public int? Month { get; set; }
        public double? Submit { get; set; }
        public double? Approved { get; set; }
        public double? Paid { get; set; }
    }
}
