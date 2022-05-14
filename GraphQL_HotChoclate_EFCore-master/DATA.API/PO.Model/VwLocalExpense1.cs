using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class VwLocalExpense1
    {
        public long ExpenseId { get; set; }
        public string PeriodForm { get; set; }
        public string PeriodTo { get; set; }
        public double? Amount { get; set; }
        public double? ApprovedAmount { get; set; }
        public int? StatusId { get; set; }
        public string Statusname { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedName { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public string UpdatedName { get; set; }
    }
}
