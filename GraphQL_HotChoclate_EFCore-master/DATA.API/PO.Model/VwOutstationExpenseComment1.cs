using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class VwOutstationExpenseComment1
    {
        public int? ExpenseId { get; set; }
        public string Comments { get; set; }
        public string StatusName { get; set; }
        public string UserName { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
