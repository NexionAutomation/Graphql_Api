using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ChartstempTable
    {
        public string Year { get; set; }
        public double? Submit { get; set; }
        public double? Approved { get; set; }
        public double? Complate { get; set; }
    }
}
