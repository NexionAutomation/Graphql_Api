using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseStatusState
    {
        public int? ExpenseId { get; set; }
        public int? StatusId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public string Comments { get; set; }
        [Key]
        public long Rid { get; set; }
    }
}
