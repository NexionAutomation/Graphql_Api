﻿using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmAdminModuleMaster
    {
        public int ModuleId { get; set; }
        public string ModuleName { get; set; }
        public int? ModuleOrder { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public int Rid { get; set; }
    }
}
