using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseHead
    {
        [Key]
        public long ExpenseId { get; set; }
        public string Title { get; set; }
        public DateTime? PeriodForm { get; set; }
        public DateTime? PeriodTo { get; set; }
        public string WorkOrderId { get; set; }
        public string Location { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
    }
}
