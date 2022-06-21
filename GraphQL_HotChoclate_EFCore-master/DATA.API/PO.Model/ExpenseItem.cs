using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseItem
    {
        public int? ExpenseId { get; set; }
        public DateTime? Date { get; set; }
        public int? ExpenseTypeId { get; set; }
        public double? Amount { get; set; }
        public double? ApprovedAmount { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public string Description { get; set; }
        public string PaidBy { get; set; }
        public double? Distance { get; set; }
        public double? ParkingAmt { get; set; }
        public double? Amt { get; set; }
        [Key]
        public long ExpenseItemsId { get; set; }
    }
}
