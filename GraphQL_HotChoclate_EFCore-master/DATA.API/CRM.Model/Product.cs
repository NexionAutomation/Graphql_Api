using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Product
    {
        public Product()
        {
            Orders = new HashSet<Order>();
        }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public byte[] ProductImg { get; set; }
        public int? CreatedBy { get; set; }
        public int? LastUpdatedBy { get; set; }
        public DateTime LastUpdated { get; set; }
        public int SupplierId { get; set; }
        public int? CategoryId { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
        public int CompanyId { get; set; }

        public virtual ProductCategory Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual User CreatedByNavigation { get; set; }
        public virtual User LastUpdatedByNavigation { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
