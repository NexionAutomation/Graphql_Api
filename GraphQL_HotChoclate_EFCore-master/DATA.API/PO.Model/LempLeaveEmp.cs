using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class LempLeaveEmp
    {
        public int Leid { get; set; }
        public string LeaveTypes { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public string NumberOfDay { get; set; }
        public string RemainingOfDay { get; set; }
        public string LeaveReasion { get; set; }
        public DateTime? CreatedBy { get; set; }
        public string CreatedTo { get; set; }
        public string ApprovelStatus { get; set; }
        public string ApprovelId { get; set; }
        public string StatusUser { get; set; }
        public string Days { get; set; }
    }
}
