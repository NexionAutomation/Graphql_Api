using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmAdminSubModuleMaster
    {
        public int ModuleId { get; set; }
        public int SubModuleId { get; set; }
        public string SubModuleName { get; set; }
        public DateTime CreationDate { get; set; }
        public int CuserId { get; set; }
        public DateTime ModificationDate { get; set; }
        public int MuserId { get; set; }
        public int SubModuleOrder { get; set; }
        public string NavigationUrl { get; set; }
        public int Rid { get; set; }
    }
}
