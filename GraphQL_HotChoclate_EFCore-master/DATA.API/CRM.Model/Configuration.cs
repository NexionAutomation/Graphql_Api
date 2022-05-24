using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Configuration
    {
        public int CompanyId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
