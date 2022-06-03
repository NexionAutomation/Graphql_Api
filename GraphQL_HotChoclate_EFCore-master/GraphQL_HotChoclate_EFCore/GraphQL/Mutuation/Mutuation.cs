using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
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


        public Task<IQueryable<ResponseData<string>>> CMTmAdminSubModuleMasters(ResponseData<CMAdminSubModuleMaster> data, string triger)
        {

            try
            {



                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();

                if (triger == "INSERT")
                {
                    using (var dbContextTransaction1 = _poContext12.Database.BeginTransaction())
                    {
                        try
                        {




                            var data1 = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();
                            CMAdminSubModuleMaster objCustomer = new CMAdminSubModuleMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            //objCustomer.moduleId,
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.SubModuleName = data1.SubModuleName;
                            objCustomer.CreationDate = DateTime.Now;//data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.SubModuleOrder = data1.SubModuleOrder;
                            objCustomer.NavigationUrl = data1.NavigationUrl;
                            //objCustomer.Rid = data1.Rid;



                            _poContext12.CMAdminSubModuleMasters.Add(objCustomer);
                            _poContext12.SaveChangesAsync();


                            //dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "INSERT");
                            responseDatas2.Add(dat12);
                            return Task.Run(() => responseDatas2.AsQueryable());
                        }
                        catch (Exception ex)
                        {
                           // dbContextTransaction1.Rollback();

                        }
                    }

                }
                else if (triger == "UPDATE")
                {
                   
                       
                            var data1 = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();
                            CMAdminSubModuleMaster objCustomer = new CMAdminSubModuleMaster();
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.SubModuleName = data1.SubModuleName;
                           // objCustomer.CreationDate = DateTime.Now;//data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.SubModuleOrder = data1.SubModuleOrder;
                            objCustomer.NavigationUrl = data1.NavigationUrl;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMAdminSubModuleMasters.Update(objCustomer);
                            _poContext12.SaveChangesAsync();


                    

                            //List<string> tmUserMaster = data //_poContext12.CMAdminModuleMasters.Select(a => a).ToList();
                    ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "UPADATE");
                            responseDatas2.Add(dat);
                            return Task.Run(() => responseDatas2.AsQueryable());

                       
                       
                    
                }
                else if (triger == "DELETE")
                {



                    CMAdminSubModuleMaster objCustomer = new CMAdminSubModuleMaster();

                    objCustomer.Rid = Convert.ToInt32(data.ID);

                    _poContext12.CMAdminSubModuleMasters.Remove(objCustomer);
                    _poContext12.SaveChanges();
                    //dbContextTransaction.Commit();
                    //List<string> tmUserMaster = _poContext12.CMAdminModuleMasters.Select(a => a).ToList();
                    ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "DELETE");
                    responseDatas2.Add(dat);
                    return Task.Run(() => responseDatas2.AsQueryable());
                }

                ResponseData<string> dat1 = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: "Data Not (" + triger + ")");
                responseDatas2.Add(dat1);
                return Task.Run(() => responseDatas2.AsQueryable());

            }
            catch (Exception ex)
            {
                // dbContextTransaction.Rollback();
                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                responseDatas2.Add(dat);
                return Task.Run(() => responseDatas2.AsQueryable());
            }



        }
    }




}
