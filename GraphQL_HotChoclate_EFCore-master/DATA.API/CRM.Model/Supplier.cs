using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int ContactId { get; set; }

        public virtual Contact Contact { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
