using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class TmPurchaseHead
    {
        [Key]
        public int? PoId { get; set; }
        public int? CompanyId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string PaymentTerms { get; set; }
        public string IndentNo { get; set; }
        public string FreightTerms { get; set; }
        public string WorkOrderNo { get; set; }
        public string Gst { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Remarks { get; set; }
        public double? Total { get; set; }
        public string Enduser { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public string DeliveryMode { get; set; }

       // [DataMember]
       // public string CompanyName { get; set; }
        // [ScaffoldColumn(false)]
       // [DataMember]
       // public string SupplierName { get; set; }
        public int? Id { get; set; }
    }


    public partial class TmPurchaseHead2
    {
        [Key]

        public int? PoId { get; set; }
        public int? CompanyId { get; set; }
        public int? SupplierId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string PaymentTerms { get; set; }
        public string IndentNo { get; set; }
        public string FreightTerms { get; set; }
        public string WorkOrderNo { get; set; }
        public string Gst { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Remarks { get; set; }
        public double? Total { get; set; }
        public string Enduser { get; set; }
        public DateTime? CreationDate { get; set; }
        public int? CuserId { get; set; }
        public DateTime? ModificationDate { get; set; }
        public int? MuserId { get; set; }
        public string DeliveryMode { get; set; }
         public string CompanyName { get; set; }
         public string SupplierName { get; set; }
        public int? Id { get; set; }
    }

}
