using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseType
    {
        [Key]
        public long ExpenseTypeId { get; set; }
        public string TypeName { get; set; }
        public long? EgroupId { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdateOn { get; set; }
        public int? UpdateBy { get; set; }
        public int? Rate { get; set; }
        public bool? Amt { get; set; }
        public bool? Km { get; set; }
        public bool? Park { get; set; }
    }
}
