using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmStateMaster
    {

        [Key]
        public int Statecode { get; set; }
        public string Statename { get; set; }
        public string DisplayAs { get; set; }
        public int Countrycode { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Modificationdate { get; set; }
        public int Usercode { get; set; }
        public string Deleted { get; set; }
        public string Editable { get; set; }
    }
}
