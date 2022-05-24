using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Company
    {
        public Company()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? Country { get; set; }
        public DateTime? LicenseFrom { get; set; }
        public DateTime? LicenseTo { get; set; }
        public int? NbrOfLicense { get; set; }
        public bool? Active { get; set; }
        public string BaseCurrency { get; set; }
        public string AcctNbrPrefix { get; set; }
        public string LeadsPrefix { get; set; }
        public byte[] Logo { get; set; }
        public string Theme { get; set; }
        public string FinancialFromMonth { get; set; }
        public string FinancialToMonth { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
