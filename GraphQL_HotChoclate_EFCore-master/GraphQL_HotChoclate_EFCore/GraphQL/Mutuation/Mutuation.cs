using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.Models;
using GraphQL_HotChoclate_EFCore.Services;
using HotChocolate.Data;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
                            objCustomer.TargetModule = data1.TargetModule;
                            objCustomer.NavigationUrl = data1.NavigationUrl;
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
                            objCustomer.TargetModule = data1.TargetModule;
                            objCustomer.NavigationUrl = data1.NavigationUrl;




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




        public async Task<IQueryable<ResponseData<string>>> CMWebUserRights(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                        //    var book = new ExcelQueryFactory("pathToExcelFile");
                        //    var australia = from x in book.Worksheet()
                        //                    where x["Country"] == "Aust"
                        //                    select new
                        //                    {
                        //                        Country = x["Country"],
                        //                        BookCode = x["Code"],
                        //                        BookName = x["Name"]
                        //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                           

                            objCustomer.GroupId= data1.GroupId;
                            objCustomer.ModuleId= data1.ModuleId;
                            objCustomer.SubModuleId= data1.SubModuleId;
                            objCustomer.CanView= data1.CanView;
                            objCustomer.CanSave= data1.CanSave;
                            objCustomer.CanSearch= data1.CanSearch;
                            objCustomer.CanUpdate= data1.CanUpdate;
                            objCustomer.CanDelete= data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId= data1.MuserId;
                            objCustomer.UserCode= data1.UserCode;
                            objCustomer.CanExport= data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate= DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                           objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid= data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                  
                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();
                       
                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);
                    
                    });
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


        #region "Module Start"
        //-------------------------------------------------------Modules Start------------------------------------------------///

        public async Task<IQueryable<ResponseData<string>>> CMCountryMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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
        public async Task<IQueryable<ResponseData<string>>> CMCityMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        public async Task<IQueryable<ResponseData<string>>> CMCompanyMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        public async Task<IQueryable<ResponseData<string>>> CMExpenseGroupMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        public async Task<IQueryable<ResponseData<string>>> CMExpenseStatusMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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


        public async Task<IQueryable<ResponseData<string>>> CMExpenseTypeMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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


        public async Task<IQueryable<ResponseData<string>>> CMFinanceYearMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        public async Task<IQueryable<ResponseData<string>>> CMStateMasterMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        public async Task<IQueryable<ResponseData<string>>> CMSupplierMaster(ResponseData<CMWebUserRightsMaster> data, string triger)
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
                            //    var book = new ExcelQueryFactory("pathToExcelFile");
                            //    var australia = from x in book.Worksheet()
                            //                    where x["Country"] == "Aust"
                            //                    select new
                            //                    {
                            //                        Country = x["Country"],
                            //                        BookCode = x["Code"],
                            //                        BookName = x["Name"]
                            //                    };



                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.ModificationDate = DateTime.Now;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.CMWebUserRightsMasters.Add(objCustomer);
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




                            var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();
                            CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.ModuleId = data1.ModuleId;
                            objCustomer.SubModuleId = data1.SubModuleId;
                            objCustomer.CanView = data1.CanView;
                            objCustomer.CanSave = data1.CanSave;
                            objCustomer.CanSearch = data1.CanSearch;
                            objCustomer.CanUpdate = data1.CanUpdate;
                            objCustomer.CanDelete = data1.CanDelete;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.UserCode = data1.UserCode;
                            objCustomer.CanExport = data1.CanExport;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.Rid = data1.Rid;



                            _poContext12.CMWebUserRightsMasters.Update(objCustomer);
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

                    var data1 = (CMWebUserRightsMaster)data.Detail.SingleOrDefault();

                    var delobj = _poContext12.CMWebUserRightsMasters.Where(x => x.UserCode == Convert.ToInt32(data1.UserCode)
                                                 && x.ModuleId == data1.ModuleId && x.GroupId == data1.GroupId).ToList();
                    CMWebUserRightsMaster objCustomer = new CMWebUserRightsMaster();

                    //objCustomer.Rid = Convert.ToInt32(data.ID);
                    //objCustomer.Rid = 0;

                    delobj.ForEach(ele => {
                        List<CMWebUserRightsMaster> objCustomer = new List<CMWebUserRightsMaster>();

                        _poContext12.CMWebUserRightsMasters.RemoveRange(delobj);

                    });
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

        //--------------------------------------------------------End Modules----------------------------------------------//
        #endregion
        //---------------------------------------------------File Uplode ------------------------------------------//
        public async Task<IQueryable<ResponseData<string>>> UploadFileAsync(IFile files)
        {
            try
            {
                //var fileName = files.Name;
                //var fileSize = files.Length;
                //await using Stream stream = files.OpenReadStream();
                //var path = Environment.CurrentDirectory;

                List<IFile> data=new List<IFile>();
                data.Add(files);


                List<string> result = new List<string>();

                Console.WriteLine(data.Count);

                foreach (var f in data)
                {
                    if (f.Length > 0)
                    {
                        Directory.CreateDirectory("Resources");
                        using (var stream1 = new FileStream("Resources", FileMode.Open))
                        {
                           
                            await f.CopyToAsync(stream1);
                            result.Add(f.Name);
                        }
                    }
                }


                


                //using (var writer = File.Create("C:\\"))
                //{
                    
                //    await stream.CopyToAsync(writer).ConfigureAwait(false);
                //}
             
                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "success");
                responseDatas2.Add(dat);
                return await Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {

                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                responseDatas2.Add(dat);
                return await Task.Run(() => responseDatas2.AsQueryable());
            }

        }

        //--------------------------------------------------- End File Uplode ------------------------------------------//
        //public async Task<bool> UploadFileAsync(IFile file)
        //{
        //    //var fileName = file.Name;
        //    //var fileSize = file.Length;

        //    //await using Stream stream = file.OpenReadStream();

        //    return true;
        //    // We can now work with standard stream functionality of .NET
        //    // to handle the file.
        //}

        //public static IFormFile GetFile(this IResolverContext ctx, NameString name)
        //{
        //    var contextAccessor = ctx.Service<IHttpContextAccessor>();
        //    return contextAccessor.HttpContext.Request.Form.Files[name.Value];
        //}




    }




}
