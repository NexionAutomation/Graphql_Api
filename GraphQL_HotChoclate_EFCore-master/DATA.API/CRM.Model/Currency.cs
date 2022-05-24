using System;
using System.Collections.Generic;

#nullable disable

namespace GraphQl.DATA.API.Models
{
    public partial class Currency
    {
        public string Code { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
    }
}
