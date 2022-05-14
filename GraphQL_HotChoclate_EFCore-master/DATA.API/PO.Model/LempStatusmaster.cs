using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LempStatusmaster
    {
        public int SId { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
        public string LmId { get; set; }
        public DateTime? CreatedBy { get; set; }
        public string CreatedOn { get; set; }
    }
}
