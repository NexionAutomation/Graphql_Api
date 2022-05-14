using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LocalExpenseHead
    {
        public long ExpenseId { get; set; }
        public DateTime? PeriodForm { get; set; }
        public DateTime? PeriodTo { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
    }
}
