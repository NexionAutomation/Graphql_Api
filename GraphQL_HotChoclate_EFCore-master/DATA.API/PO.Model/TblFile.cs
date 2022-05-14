using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TblFile
    {
        public string Name { get; set; }
        public string ContentType { get; set; }
        public byte[] Data { get; set; }
        public string ImagDescription { get; set; }
        public int? DExpenseId { get; set; }
        public int Id { get; set; }
    }
}
