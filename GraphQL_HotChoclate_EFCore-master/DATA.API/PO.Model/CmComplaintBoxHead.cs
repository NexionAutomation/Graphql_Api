using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GraphQl.DATA.API.PO.Model
{
    public partial class CmComplaintBoxHead
    {
        [Key]
        public long ExpenseId { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? Tokennumber { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
    }
}
