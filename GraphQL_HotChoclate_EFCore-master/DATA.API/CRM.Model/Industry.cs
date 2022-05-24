using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Industry
    {
        public Industry()
        {
            Accounts = new HashSet<Account>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public DateTime LastUpdated { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}
