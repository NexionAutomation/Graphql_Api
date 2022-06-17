using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    
    public partial class TmCountryMaster
    {
       [Key]
        public int Countrycode { get; set; }
        public string Countryname { get; set; }
        public string DisplayAs { get; set; }
        public DateTime? Creationdate { get; set; }
        public DateTime? Modificationdate { get; set; }
        public int? Usercode { get; set; }
        public string Deleted { get; set; }
        public string Editable { get; set; }
    }
}
