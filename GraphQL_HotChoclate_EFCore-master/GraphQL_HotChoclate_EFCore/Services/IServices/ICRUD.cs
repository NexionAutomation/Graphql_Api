using GraphQl.Api.Utility;
using GraphQl.DATA.API.PO.Model;
using System.Threading.Tasks;

namespace GraphQl.Api.Services.IServices
{
    public interface ICRUD<T,U> where T : class
        where U : class
    {
        Task<ResponseData<U>> GET<T>(T Data);
        Task<ResponseData<U>> GETByID<T>(T Data);
        Task<ResponseData<U>> Create<T>(T Data );
        Task<ResponseData<U>> Create(TmUserMaster Data);
        Task<ResponseData<U>> Update<T>(T Data);
        Task<ResponseData<U>> Delete<T>(T Data);

    }
}
