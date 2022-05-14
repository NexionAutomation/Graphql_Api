using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmSupplierMaster
    {
        public int? Id { get; set; }
        public string SupplierName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string ContactPerson { get; set; }
        public string CmobileNo { get; set; }
        public string Gst { get; set; }
        public string RecordStatus { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
    }
}
