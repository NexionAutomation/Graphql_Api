using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Contact
    {
        public Contact()
        {
            Suppliers = new HashSet<Supplier>();
        }

        public int ContactId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public int? State { get; set; }
        public int? Country { get; set; }

        public virtual Country CountryNavigation { get; set; }
        public virtual State StateNavigation { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }
    }
}
