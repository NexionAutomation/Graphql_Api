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


        public string Title { get; set; }
        public string WorkOrderId { get; set; }
        public string Location { get; set; }
        public decimal Amount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public int StatusID { get; set; }

        public string statusname { get; set; }
        public string CreatedName { get; set; }

        public string UpdatedName { get; set; }



    

    }
}
