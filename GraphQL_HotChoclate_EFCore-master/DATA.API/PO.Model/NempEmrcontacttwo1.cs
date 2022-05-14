using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class NempEmrcontacttwo1
    {
        public int EcId { get; set; }
        public string Name { get; set; }
        public string Relationship { get; set; }
        public string HomeTel { get; set; }
        public string WorkMobile { get; set; }
        public string Personalmobile { get; set; }
        public string MedicalconditionDrop { get; set; }
        public string Medicalcondition { get; set; }
        public DateTime? Createdby { get; set; }
        public int? PdId { get; set; }
    }
}
