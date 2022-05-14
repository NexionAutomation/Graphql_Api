using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmCityMaster
    {
        public int Citycode { get; set; }
        public string Cityname { get; set; }
        public int Statecode { get; set; }
        public DateTime Creationdate { get; set; }
        public DateTime Modificationdate { get; set; }
        public int Usercode { get; set; }
        public string Deleted { get; set; }
        public string Editable { get; set; }
    }
}
