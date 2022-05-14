using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseStatusMaster
    {
        public string StatusName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public long StatusId { get; set; }
    }
}
