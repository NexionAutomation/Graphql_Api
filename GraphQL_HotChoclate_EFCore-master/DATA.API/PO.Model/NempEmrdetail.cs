using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class NempEmrdetail
    {
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string ContactAddress { get; set; }
        public string PostCode { get; set; }
        public string HomeTel { get; set; }
        public string WorkMobile { get; set; }
        public string Personalmobile { get; set; }
        public DateTime? Createdby { get; set; }
        public int? PdId { get; set; }
        public int EdId { get; set; }
    }
}
