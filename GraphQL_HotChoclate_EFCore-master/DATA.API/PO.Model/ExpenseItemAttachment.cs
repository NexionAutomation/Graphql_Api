using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class ExpenseItemAttachment
    {
        public int? ExpenseId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
        //public byte[] Data { get; set; }
        public string ImagDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Key]
        public int AttchmentId { get; set; }
    }

    public partial class ExpenseItemAttachment07
    {
        public int? ExpenseId { get; set; }
        public string Name { get; set; }
        public string ContentType { get; set; }
       
        public string ImagDescription { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        [Key]
        public int AttchmentId { get; set; }
    }
}
