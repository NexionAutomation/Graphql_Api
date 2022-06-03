using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.Models;
using GraphQL_HotChoclate_EFCore.Services;
using HotChocolate.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_HotChoclate_EFCore.GraphQL
{
    public class PoUserMutation
    {
        public readonly ILogger Logger12;
        public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED12;
        public readonly poContext _poContext12;
        
       public PoUserMutation(poContext _poContext12)
        {
            this._poContext12 = _poContext12;
        }


        public Task<ResponseData<TmUserMaster>> CMTmAdminSubModuleMasters(TmUserMaster data)
        {
            try
            {

                //ResponseData<TmUserMaster> reportdata = new ResponseData<TmUserMaster>(new
                //{
                //    Code = "",
                //    ID = "",
                //    Message = "",
                //    Status = "",
                //    Detail = null,
                
                
                //});

                //reportdata
                //List<CMAdminSubModuleMaster> tmUserMaster = context.CMAdminSubModuleMasters.ToList();
                //return Task.Run(() => tmUserMaster.AsQueryable());
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }

  

}
