using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Ramaster
    {
        public int Id { get; set; }
        public string Ravalue { get; set; }
        public string Description { get; set; }
        public DateTime LastUpdated { get; set; }
        public int LastUpdatedBy { get; set; }
        public bool? Active { get; set; }
    }
}
