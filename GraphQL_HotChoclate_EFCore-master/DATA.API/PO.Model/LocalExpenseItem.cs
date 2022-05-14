using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LocalExpenseItem
    {
        public int? ExpenseId { get; set; }
        public DateTime? Date { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public string Purpose { get; set; }
        public int? TransportTypeId { get; set; }
        public int? Distance { get; set; }
        public double? Amount { get; set; }
        public double? ApprovedAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public string Description { get; set; }
        public double? ParkingAmt { get; set; }
        public double? Amt { get; set; }
        public long ExpenseItemsId { get; set; }
    }
}
