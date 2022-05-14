using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmUserMaster
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public string Upassword { get; set; }
        public string EmailId { get; set; }
        public string MobileNo { get; set; }
        public int? GroupId { get; set; }
        public string AccountStatus { get; set; }
        public string FromTime { get; set; }
        public string FromTimeAmPm { get; set; }
        public string ToTime { get; set; }
        public string ToTimeAmPm { get; set; }
        public string UserImage { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public string Recordstatus { get; set; }
        public string ReasonForDeletion { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DuserCode { get; set; }
        public int? UserCode { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public int? ReportingManager { get; set; }
        public int Rid { get; set; }
    }
}
