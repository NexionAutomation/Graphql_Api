using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class NempBankDetail
    {
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string IfscCode { get; set; }
        public string BranchAddress { get; set; }
        public DateTime? Createdby { get; set; }
        public int? PdId { get; set; }
        public int BdId { get; set; }
    }
}
