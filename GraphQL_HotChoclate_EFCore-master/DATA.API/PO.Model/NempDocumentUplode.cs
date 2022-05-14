using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class NempDocumentUplode
    {
        public string Photo { get; set; }
        public string AddharCard { get; set; }
        public string Voterid { get; set; }
        public string EducationProof { get; set; }
        public string ExperienceLetter { get; set; }
        public string NocLetter { get; set; }
        public DateTime? Createdby { get; set; }
        public int? PdId { get; set; }
        public int DuId { get; set; }
    }
}
