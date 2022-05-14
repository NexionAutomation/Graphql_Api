using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmGroupMaster
    {
        public int Rid { get; set; }
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
    }
}
