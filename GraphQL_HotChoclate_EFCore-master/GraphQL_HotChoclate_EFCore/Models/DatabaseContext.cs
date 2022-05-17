using GraphQl.Api.Models;
using GraphQl.DATA.API.PO.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore.Models
{
    public  class poContextDB
    {

        public readonly poContext poContext;
        public readonly DTOContext DTOContext;
        public  poContextDB(poContext poContext)
        {
            DTOContext.poContextDb =  poContext;
        }

        public DTOContext GETDTOContext()
        {
            return DTOContext;
        }
    }


}
