using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class NempPersonalDetail1
    {
        public int PdId { get; set; }
        public string Name { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HomeAddress { get; set; }
        public string PostCode { get; set; }
        public string HomeTel { get; set; }
        public string Mobile { get; set; }
        public DateTime? CreatedBy { get; set; }
    }
}
