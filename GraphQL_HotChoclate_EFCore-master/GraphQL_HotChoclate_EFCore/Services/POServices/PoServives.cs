using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.Models;
using HotChocolate;
using HotChocolate.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GraphQL_HotChoclate_EFCore.Services
{
    public partial class PoUserServices  //: ICRUD
    {
        public readonly ILogger Logger;
        public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED;
        public readonly poContext _poContext;


        ICollection<ResponseData<TmUserMaster>> responseDatas1;
        public PoUserServices(ILogger<PoUserServices> logger)
        {
            Logger = logger;

            //CURED = cRUD;
        }
        //public Task<ResponseData> Create<TmUserMaster>(  TmUserMaster collection)
        //{


        //    return  Task.Run( ()=>new ResponseData { Message="success",Code="122",Detail="testing",ID="1",Status="Success"});
        //}
        [UseFirstOrDefault]

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<TmUserMaster>>> Create([Service] poContext collection)
        {
            try
            {

                List<ResponseData<TmUserMaster>> responseDatas2 = new List<ResponseData<TmUserMaster>>();
                List<TmUserMaster> tmUserMaster = collection.TmUserMasters.Select(a => a).ToList();
                ResponseData<TmUserMaster> dat = ResponseMSG<TmUserMaster>.Success<List<TmUserMaster>>(Detail: tmUserMaster);
                //res
                //ResponseData<ResponseStatus> dat = ResponseMSG<ResponseStatus>.Success<List<ResponseStatus>>(Detail: ResponseStatus.Status="hello".ToList());
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }


    }
}
