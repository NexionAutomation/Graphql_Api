using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    
    public partial class TmCompanyMaster
    {
        [Key]
      
        public int? Id { get; set; }
        public string CompanyName { get; set; }
        public string Caddress1 { get; set; }
        public string Caddress2 { get; set; }
        public string Caddress3 { get; set; }
        public string CemailId { get; set; }
        public string CmobileNo { get; set; }
        public string Cwebsite { get; set; }
        public string Cphoto { get; set; }
        public string Iname { get; set; }
        public string Iaddress1 { get; set; }
        public string Iaddress2 { get; set; }
        public string Iaddress3 { get; set; }
        public string Igst { get; set; }
        public string ImobileNo { get; set; }
        public string IpanNo { get; set; }
        public string Sname { get; set; }
        public string Saddress1 { get; set; }
        public string Saddress2 { get; set; }
        public string Saddress3 { get; set; }
        public string SattendentName { get; set; }
        public string SmobileNo { get; set; }
        public string SpanNo { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public string Recordstatus { get; set; }
        public string ReasonForDeletion { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? DuserCode { get; set; }
    }


    public partial class TmCompanyMaster1
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Caddress1 { get; set; }
        public string Caddress2 { get; set; }
        public string Caddress3 { get; set; }
        public string CemailId { get; set; }
        public string CmobileNo { get; set; }
        public string Cwebsite { get; set; }
        public string Cphoto { get; set; }
        public string Iname { get; set; }
        public string Iaddress1 { get; set; }
        public string Iaddress2 { get; set; }
        public string Iaddress3 { get; set; }
        public string Igst { get; set; }
        public string ImobileNo { get; set; }
        public string IpanNo { get; set; }
        public string Sname { get; set; }
        public string Saddress1 { get; set; }
        public string Saddress2 { get; set; }
        public string Saddress3 { get; set; }
        public string SattendentName { get; set; }
        public string SmobileNo { get; set; }
        public string SpanNo { get; set; }
       
        public int? CuserId { get; set; }
     
        public int? MuserId { get; set; }
        public string Recordstatus { get; set; }
        public string ReasonForDeletion { get; set; }
     
        public int? DuserCode { get; set; }
    }

}
