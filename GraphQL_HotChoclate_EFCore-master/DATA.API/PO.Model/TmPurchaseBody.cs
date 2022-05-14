using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmPurchaseBody
    {
        public int? PoId { get; set; }
        public string Description { get; set; }
        public string Uom { get; set; }
        public int? Qty { get; set; }
        public double? ListPrice { get; set; }
        public double? Dis { get; set; }
        public double? UnitPrice { get; set; }
        public double? NetPrice { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public decimal Id { get; set; }
        public string Catname { get; set; }
    }
}
