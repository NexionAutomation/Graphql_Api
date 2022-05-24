using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Account
    {
        public Account()
        {
            Leads = new HashSet<Lead>();
        }

        public int Id { get; set; }
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int State { get; set; }
        public string PinCode { get; set; }
        public int Country { get; set; }
        public int Owner { get; set; }
        public int AccountType { get; set; }
        public DateTime? LastUpdated { get; set; }
        public int? LastUpdatedBy { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? Created { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? Active { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonMobileNo { get; set; }
        public string ContactPersonLandlineNo { get; set; }
        public string Website { get; set; }

        public virtual AccountType AccountTypeNavigation { get; set; }
        public virtual Country CountryNavigation { get; set; }
        public virtual Industry Industry { get; set; }
        public virtual User OwnerNavigation { get; set; }
        public virtual State StateNavigation { get; set; }
        public virtual ICollection<Lead> Leads { get; set; }
    }
}
