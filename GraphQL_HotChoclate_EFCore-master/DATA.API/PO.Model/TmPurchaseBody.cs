using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Key]
        public decimal Id { get; set; }
        public string Catname { get; set; }
    }




    public partial class ExcelImporter01
    {
        public string T0 { get; set; }
        public string T1 { get; set; }
        public string T2 { get; set; }
        public string T3 { get; set; }
        public string T4 { get; set; }
        public string T5 { get; set; }
        public string T6 { get; set; }
        public string T7 { get; set; }
        public string T8 { get; set; }
        public string T9 { get; set; }
        public string T10 { get; set; }
        public string T11 { get; set; }
        public string T12 { get; set; }
        public string T13 { get; set; }
        public string T14 { get; set; }
        public string T15 { get; set; }
        public string T16 { get; set; }
        public string T17 { get; set; }
        public string T18 { get; set; }
        public string T19 { get; set; }
        public string T20 { get; set; }
        public string T21 { get; set; }
        public string T22 { get; set; }
        public string T23 { get; set; }
        public string T24 { get; set; }
        public string T25 { get; set; }
        public string T26 { get; set; }
        public string T27 { get; set; }
        public string T28 { get; set; }
        public string T29 { get; set; }
        public string T30 { get; set; }
        public string T31 { get; set; }
        public string T32 { get; set; }
        public string T33 { get; set; }
        public string T34 { get; set; }
        public string T35 { get; set; }
        public string T36 { get; set; }
        public string T37 { get; set; }
        public string T38 { get; set; }
        public string T39 { get; set; }
        public string T40 { get; set; }
        public string T41 { get; set; }
        public string T42 { get; set; }
        public string T43 { get; set; }
        public string T44 { get; set; }
        public string T45 { get; set; }
        public string T46 { get; set; }
        public string T47 { get; set; }
        public string T48 { get; set; }
        public string T49 { get; set; }
        public string T50 { get; set; }
        public string T51 { get; set; }



    }




    public partial class Attandance
    {
        public string Sno { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Day { get; set; }

        public string Time { get; set; }

        public string IN { get; set; }
        public string OUT { get; set; }




    }

}
