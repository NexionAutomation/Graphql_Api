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


      


        public async Task<IQueryable<ResponseData<string>>> CMTmAdminSubModuleMasters(ResponseData<CMAdminSubModuleMaster> data, string triger)
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
                            // objCustomer.Rid = data1.Rid;
                            //objCustomer.MuserId = data1.MuserId;
                            objCustomer.ModuleId = data1.ModuleId;//data1.CreationDate;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.SubModuleName = data1.SubModuleName;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.SubModuleOrder = data1.SubModuleOrder;
                            objCustomer.ModificationDate = DateTime.Now;
                            //objCustomer.Rid = data1.Rid;
                            //objCustomer.Rid = data1.Rid;



        _poContext12.CMAdminSubModuleMasters.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();


                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "INSERT");
                            responseDatas2.Add(dat12);
                            return await Task.Run(() => responseDatas2.AsQueryable());
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction1.Rollback();


                            ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                            responseDatas2.Add(dat);
                            return await Task.Run(() => responseDatas2.AsQueryable());

                        }
                    }

                }
                else if (triger == "UPDATE")
                {
                    using (var dbContextTransaction1 = _poContext12.Database.BeginTransaction())
                    {

                        try
                        {




                            var data1 = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();
                            CMAdminSubModuleMaster objCustomer = new CMAdminSubModuleMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            //objCustomer.moduleId,
                            objCustomer.ModuleId = data1.ModuleId;//data1.CreationDate;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.SubModuleName = data1.SubModuleName;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.SubModuleOrder = data1.SubModuleOrder;
                            objCustomer.Rid = data1.Rid;




                            _poContext12.CMAdminSubModuleMasters.Update(objCustomer);
                            _poContext12.SaveChanges();


                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "UPDATE");
                            responseDatas2.Add(dat12);
                            return await Task.Run(() => responseDatas2.AsQueryable());
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction1.Rollback();


                            ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                            responseDatas2.Add(dat);
                            return await Task.Run(() => responseDatas2.AsQueryable());

                        }


                    }
                }
                else if (triger == "DELETE")
                {



                    CMAdminModuleMaster objCustomer = new CMAdminModuleMaster();

                    objCustomer.Rid = Convert.ToInt32(data.ID);

                    _poContext12.CMAdminModuleMasters.Remove(objCustomer);
                    await _poContext12.SaveChangesAsync();
                    //dbContextTransaction.Commit();
                    //List<string> tmUserMaster = _poContext12.CMAdminModuleMasters.Select(a => a).ToList();
                    ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "DELETE");
                    responseDatas2.Add(dat);
                    return await Task.Run(() => responseDatas2.AsQueryable());
                }

                ResponseData<string> dat1 = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: "Data Not (" + triger + ")");
                responseDatas2.Add(dat1);
                return await Task.Run(() => responseDatas2.AsQueryable());

            }
            catch (Exception ex)
            {
                // dbContextTransaction.Rollback();
                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                responseDatas2.Add(dat);
                return await Task.Run(() => responseDatas2.AsQueryable());
            }



        }


        public async Task<IQueryable<ResponseData<string>>> CMTmAdminModuleMasters(ResponseData<CMAdminModuleMasterUser> data, string triger)
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




                            var data1 = (CMAdminModuleMasterUser)data.Detail.SingleOrDefault();
                            CMAdminModuleMaster objCustomer = new CMAdminModuleMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            //objCustomer.moduleId,
                           // objCustomer.Rid = data1.Rid;
                            //objCustomer.MuserId = data1.MuserId;
                            objCustomer.ModuleOrder = data1.ModuleOrder;//data1.CreationDate;
                            objCustomer.ModuleName = data1.ModuleName;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.CuserId = data1.CuserId;
                            //objCustomer.Rid = data1.Rid;



                            _poContext12.CMAdminModuleMasters.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();


                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "INSERT");
                            responseDatas2.Add(dat12);
                            return await Task.Run(() => responseDatas2.AsQueryable());
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction1.Rollback();


                            ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                            responseDatas2.Add(dat);
                            return await Task.Run(() => responseDatas2.AsQueryable());

                        }
                    }

                }
                else if (triger == "UPDATE")
                {
                    using (var dbContextTransaction1 = _poContext12.Database.BeginTransaction())
                    {

                        try
                        {




                            var data1 = (CMAdminModuleMasterUser)data.Detail.SingleOrDefault();
                            CMAdminModuleMaster objCustomer = new CMAdminModuleMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            //objCustomer.moduleId,
                            objCustomer.Rid = data1.Rid;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.ModuleOrder = data1.ModuleOrder;//data1.CreationDate;
                            objCustomer.ModuleName = data1.ModuleName;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                          



                            _poContext12.CMAdminModuleMasters.Update(objCustomer);
                            _poContext12.SaveChanges();


                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "UPDATE");
                            responseDatas2.Add(dat12);
                            return await Task.Run(() => responseDatas2.AsQueryable());
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction1.Rollback();


                            ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                            responseDatas2.Add(dat);
                            return await Task.Run(() => responseDatas2.AsQueryable());

                        }


                    }
                }
                else if (triger == "DELETE")
                {



                    CMAdminModuleMaster objCustomer = new CMAdminModuleMaster();

                    objCustomer.Rid = Convert.ToInt32(data.ID);

                    _poContext12.CMAdminModuleMasters.Remove(objCustomer);
                    await _poContext12.SaveChangesAsync();
                    //dbContextTransaction.Commit();
                    //List<string> tmUserMaster = _poContext12.CMAdminModuleMasters.Select(a => a).ToList();
                    ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "DELETE");
                    responseDatas2.Add(dat);
                    return await Task.Run(() => responseDatas2.AsQueryable());
                }

                ResponseData<string> dat1 = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: "Data Not (" + triger + ")");
                responseDatas2.Add(dat1);
                return await Task.Run(() => responseDatas2.AsQueryable());

            }
            catch (Exception ex)
            {
                // dbContextTransaction.Rollback();
                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                responseDatas2.Add(dat);
                return await Task.Run(() => responseDatas2.AsQueryable());
            }



        }
    }




}
