﻿using GraphQl.Api.Services.IServices;
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

        public async Task<IQueryable<ResponseData<string>>> CMCountryMaster(ResponseData<TmCountryMaster> data, string triger)
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



                            var data1 = (TmCountryMaster)data.Detail.SingleOrDefault();
                            TmCountryMaster objCustomer = new TmCountryMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();
                           ;

                            objCustomer.Countrycode = _poContext12.TmCountryMasters.Select(x => x.Countrycode).Max() + 1;
                            objCustomer.Countryname = data1.Countryname;
                            objCustomer.DisplayAs = data1.DisplayAs;
                            objCustomer.Creationdate = DateTime.Now;
                            objCustomer.Modificationdate = DateTime.Now;
                            objCustomer.Usercode = data1.Usercode;
                            objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;





                            _poContext12.TmCountryMasters.Add(objCustomer);
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




                            var data1 = (TmCountryMaster)data.Detail.SingleOrDefault();
                            TmCountryMaster objCustomer = new TmCountryMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Countrycode = data1.Countrycode;
                            objCustomer.Countryname = data1.Countryname;
                            objCustomer.DisplayAs = data1.DisplayAs;
                            objCustomer.Creationdate = data1.Creationdate;
                            objCustomer.Modificationdate = DateTime.Now;
                            objCustomer.Usercode = data1.Usercode;
                            objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;




                            _poContext12.TmCountryMasters.Update(objCustomer);
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

                    var data1 = (TmCountryMaster)data.Detail.SingleOrDefault();


                    TmCountryMaster objCustomer = new TmCountryMaster();

                    objCustomer.Countrycode = Convert.ToInt32(data1.Countrycode);
                    //objCustomer.Rid = 0;
                    _poContext12.TmCountryMasters.Remove(objCustomer);
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



        }   // ok
        public async Task<IQueryable<ResponseData<string>>> CMExpenseGroupMaster(ResponseData<TmGroupMaster> data, string triger)
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
                           


                            var data1 = (TmGroupMaster)data.Detail.SingleOrDefault();
                            TmGroupMaster objCustomer = new TmGroupMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Rid = _poContext12.TmGroupMasters.Select(x => x.Rid).Max() + 1 ;
                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.GroupName = data1.GroupName;
                            objCustomer.CreationDate = DateTime.Now;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.MuserId = data1.MuserId;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.TmGroupMasters.Add(objCustomer);
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




                            var data1 = (TmGroupMaster)data.Detail.SingleOrDefault();
                            TmGroupMaster objCustomer = new TmGroupMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Rid = data1.Rid;
                            objCustomer.GroupId = data1.GroupId;
                            objCustomer.GroupName = data1.GroupName;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.MuserId = data1.MuserId;



                            _poContext12.TmGroupMasters.Update(objCustomer);
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

                    var data1 = (TmGroupMaster)data.Detail.SingleOrDefault();

                    
                    TmGroupMaster objCustomer = new TmGroupMaster();

                    objCustomer.Rid = Convert.ToInt32(data.ID);
                  //  objCustomer.Rid = 0;

                        _poContext12.TmGroupMasters.Remove(objCustomer);

                    
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



        } // ok

        public async Task<IQueryable<ResponseData<string>>> CMCompanyMaster(ResponseData<TmCompanyMaster1> data, string triger)
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
                            


                            var data1 = (TmCompanyMaster1)data.Detail.SingleOrDefault();
                            TmCompanyMaster objCustomer = new TmCompanyMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.Id = _poContext12.TmCompanyMasters.Select(x => x.Id).Max() + 1 ;
                            objCustomer.CompanyName = data1.CompanyName;
                            objCustomer.Caddress1 = data1.Caddress1;
                            objCustomer.Caddress2 = data1.Caddress2;
                            objCustomer.Caddress3 = data1.Caddress3;
                            objCustomer.CemailId = data1.CemailId;
                            objCustomer.CmobileNo = data1.CmobileNo;
                            objCustomer.Cwebsite = data1.Cwebsite;
                            objCustomer.Cphoto = data1.Cphoto;
                            objCustomer.Iname = data1.Iname;
                            objCustomer.Iaddress1 = data1.Iaddress1;
                            objCustomer.Iaddress2 = data1.Iaddress2;
                            objCustomer.Iaddress3 = data1.Iaddress3;
                            objCustomer.Igst = data1.Igst;
                            objCustomer.ImobileNo = data1.ImobileNo;
                            objCustomer.IpanNo = data1.IpanNo;
                            objCustomer.Sname = data1.Sname;
                            objCustomer.Saddress1 = data1.Saddress1;
                            objCustomer.Saddress2 = data1.Saddress2;
                            objCustomer.Saddress3 = data1.Saddress3;
                            objCustomer.SattendentName = data1.SattendentName;
                            objCustomer.SmobileNo = data1.SmobileNo;
                            objCustomer.SpanNo = data1.SpanNo;
                            objCustomer.CreationDate = DateTime.Now;// data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = DateTime.Now;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.Recordstatus = data1.Recordstatus;
                            objCustomer.ReasonForDeletion = data1.ReasonForDeletion;
                            objCustomer.DeletedDate = DateTime.Now;
                            objCustomer.DuserCode = data1.DuserCode;





                            _poContext12.TmCompanyMasters.Add(objCustomer);
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




                            var data1 = (TmCompanyMaster1)data.Detail.SingleOrDefault();
                            TmCompanyMaster objCustomer = new TmCompanyMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();
                            objCustomer.Id = data1.Id;
                            objCustomer.CompanyName = data1.CompanyName;
                            objCustomer.Caddress1 = data1.Caddress1;
                            objCustomer.Caddress2 = data1.Caddress2;
                            objCustomer.Caddress3 = data1.Caddress3;
                            objCustomer.CemailId = data1.CemailId;
                            objCustomer.CmobileNo = data1.CmobileNo;
                            objCustomer.Cwebsite = data1.Cwebsite;
                            objCustomer.Cphoto = data1.Cphoto;
                            objCustomer.Iname = data1.Iname;
                            objCustomer.Iaddress1 = data1.Iaddress1;
                            objCustomer.Iaddress2 = data1.Iaddress2;
                            objCustomer.Iaddress3 = data1.Iaddress3;
                            objCustomer.Igst = data1.Igst;
                            objCustomer.ImobileNo = data1.ImobileNo;
                            objCustomer.IpanNo = data1.IpanNo;
                            objCustomer.Sname = data1.Sname;
                            objCustomer.Saddress1 = data1.Saddress1;
                            objCustomer.Saddress2 = data1.Saddress2;
                            objCustomer.Saddress3 = data1.Saddress3;
                            objCustomer.SattendentName = data1.SattendentName;
                            objCustomer.SmobileNo = data1.SmobileNo;
                            objCustomer.SpanNo = data1.SpanNo;
                            objCustomer.CreationDate = DateTime.Now;  //data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = DateTime.Now;//data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.Recordstatus = data1.Recordstatus;
                            objCustomer.ReasonForDeletion = data1.ReasonForDeletion;
                            objCustomer.DeletedDate = DateTime.Now;//data1.DeletedDate;
                            objCustomer.DuserCode = data1.DuserCode;



                            _poContext12.TmCompanyMasters.Update(objCustomer);
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

                    var data1 = (TmCompanyMaster1)data.Detail.SingleOrDefault();


                    TmCompanyMaster objCustomer = new TmCompanyMaster();

                    objCustomer.Id = Convert.ToInt32(data.ID);



                    _poContext12.TmCompanyMasters.Remove(objCustomer);


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



        } /// OK

        public async Task<IQueryable<ResponseData<string>>> CMCityMaster(ResponseData<TmCityMaster> data, string triger)
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



                            var data1 = (TmCityMaster)data.Detail.SingleOrDefault();
                            TmCityMaster objCustomer = new TmCityMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.Citycode = _poContext12.TmCityMasters.Select(x => x.Citycode).Max() + 1; 
                            objCustomer.Cityname = data1.Cityname;
                            objCustomer.Statecode = data1.Statecode;
                            objCustomer.Creationdate = data1.Creationdate;
                            objCustomer.Modificationdate = data1.Modificationdate;
                           objCustomer.Usercode = data1.Usercode;
                             objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;
        // objCustomer.Rid= data1.Rid;





        _poContext12.TmCityMasters.Add(objCustomer);
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




                            var data1 = (TmCityMaster)data.Detail.SingleOrDefault();
                            TmCityMaster objCustomer = new TmCityMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Citycode = data1.Citycode;
                            objCustomer.Cityname = data1.Cityname;
                            objCustomer.Statecode = data1.Statecode;
                            objCustomer.Creationdate = data1.Creationdate;
                            objCustomer.Modificationdate = data1.Modificationdate;
                            objCustomer.Usercode = data1.Usercode;
                            objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;



                            _poContext12.TmCityMasters.Update(objCustomer);
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

                    var data1 = (TmCityMaster)data.Detail.SingleOrDefault();

                    
                    TmCityMaster objCustomer = new TmCityMaster();

                    objCustomer.Citycode = Convert.ToInt32(data1.Citycode);
                    //objCustomer.Rid = 0;

                  
                        _poContext12.TmCityMasters.Remove(objCustomer);

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



        } //-- OK

        public async Task<IQueryable<ResponseData<string>>> CMExpenseStatusMaster(ResponseData<ExpenseStatusMaster> data, string triger)
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



                            var data1 = (ExpenseStatusMaster)data.Detail.SingleOrDefault();
                            ExpenseStatusMaster objCustomer = new ExpenseStatusMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.StatusName = data1.StatusName;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            //objCustomer.StatusId = _poContext12.ExpenseStatusMasters.Select(x => x.StatusId).Max() + 1 ;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.ExpenseStatusMasters.Add(objCustomer);
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




                            var data1 = (ExpenseStatusMaster)data.Detail.SingleOrDefault();
                            ExpenseStatusMaster objCustomer = new ExpenseStatusMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.StatusName = data1.StatusName;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.StatusId = data1.StatusId;



                            _poContext12.ExpenseStatusMasters.Update(objCustomer);
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

                    var data1 = (ExpenseStatusMaster)data.Detail.SingleOrDefault();

                    
                    ExpenseStatusMaster objCustomer = new ExpenseStatusMaster();

                    objCustomer.StatusId = Convert.ToInt32(data1.StatusId);
                    //objCustomer.Rid = 0;

                   
                        _poContext12.ExpenseStatusMasters.Remove(objCustomer);

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



        } //-- OK 


        public async Task<IQueryable<ResponseData<string>>> CMExpenseTypeMaster(ResponseData<ExpenseType> data, string triger)
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

                            var data1 = (ExpenseType)data.Detail.SingleOrDefault();
                            ExpenseType objCustomer = new ExpenseType();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            //objCustomer.ExpenseTypeId = data1.ExpenseTypeId;
                            objCustomer.TypeName = data1.TypeName;
                            objCustomer.EgroupId = data1.EgroupId;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Rate = data1.Rate;
                            objCustomer.Amt = data1.Amt;
                            objCustomer.Km = data1.Km;
                            objCustomer.Park = data1.Park;




                            _poContext12.ExpenseTypes.Add(objCustomer);
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




                            var data1 = (ExpenseType)data.Detail.SingleOrDefault();
                            ExpenseType objCustomer = new ExpenseType();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.ExpenseTypeId = data1.ExpenseTypeId;
                            objCustomer.TypeName = data1.TypeName;
                            objCustomer.EgroupId = data1.EgroupId;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Rate = data1.Rate;
                             objCustomer.Amt = data1.Amt;
                            objCustomer.Km = data1.Km;
                            objCustomer.Park = data1.Park;



        _poContext12.ExpenseTypes.Update(objCustomer);
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

                    var data1 = (ExpenseType)data.Detail.SingleOrDefault();

                    
                    ExpenseType objCustomer = new ExpenseType();

                    objCustomer.ExpenseTypeId = Convert.ToInt32(data1.ExpenseTypeId);
                    //objCustomer.Rid = 0;

                   
                        _poContext12.ExpenseTypes.Remove(objCustomer);

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



        } // ok


        public async Task<IQueryable<ResponseData<string>>> CMFinanceYearMaster(ResponseData<TmFinaicalYear> data, string triger)
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
                           

                            var data1 = (TmFinaicalYear)data.Detail.SingleOrDefault();
                            TmFinaicalYear objCustomer = new TmFinaicalYear();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.Id = _poContext12.TmFinaicalYears.Select(x => x.Id).Max() + 1 ;
                            objCustomer.Fyname= data1.Fyname;
                            objCustomer.StartDate= data1.StartDate;
                            objCustomer.Enddate= data1.Enddate;
                            objCustomer.PoNumber= data1.PoNumber;
                            objCustomer.CreationDate= data1.CreationDate;
                            objCustomer.CuserId= data1.CuserId;
                            objCustomer.ModificationDate= data1.ModificationDate;
                            objCustomer.MuserId= data1.MuserId;
                            objCustomer.Expenseid = data1.Expenseid;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.TmFinaicalYears.Add(objCustomer);
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




                            var data1 = (TmFinaicalYear)data.Detail.SingleOrDefault();
                            TmFinaicalYear objCustomer = new TmFinaicalYear();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Id = data1.Id;
                            objCustomer.Fyname = data1.Fyname;
                            objCustomer.StartDate = data1.StartDate;
                            objCustomer.Enddate = data1.Enddate;
                            objCustomer.PoNumber = data1.PoNumber;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.Expenseid = data1.Expenseid;



                            _poContext12.TmFinaicalYears.Update(objCustomer);
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

                    var data1 = (TmFinaicalYear)data.Detail.SingleOrDefault();

                  
                    TmFinaicalYear objCustomer = new TmFinaicalYear();

                    objCustomer.Id = Convert.ToInt32(data1.Id);
                   // objCustomer.Rid = 0;

                   
                        

                        _poContext12.TmFinaicalYears.Remove(objCustomer);

                   
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



        } // ok

        public async Task<IQueryable<ResponseData<string>>> CMStateMasterMaster(ResponseData<TmStateMaster> data, string triger)
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



                            var data1 = (TmStateMaster)data.Detail.SingleOrDefault();
                            TmStateMaster objCustomer = new TmStateMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.Statecode = _poContext12.TmStateMasters.Select(x => x.Statecode).Max() + 1; ;
                            objCustomer.Statename = data1.Statename;
                            objCustomer.DisplayAs = data1.DisplayAs;
                            objCustomer.Countrycode = data1.Countrycode;
                            objCustomer.Creationdate = data1.Creationdate;
                            objCustomer.Modificationdate = data1.Modificationdate;
                            objCustomer.Usercode = data1.Usercode;
                            objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;
        // objCustomer.Rid= data1.Rid;





        _poContext12.TmStateMasters.Add(objCustomer);
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




                            var data1 = (TmStateMaster)data.Detail.SingleOrDefault();
                            TmStateMaster objCustomer = new TmStateMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.Statecode = data1.Statecode;
                            objCustomer.Statename = data1.Statename;
                            objCustomer.DisplayAs = data1.DisplayAs;
                            objCustomer.Countrycode = data1.Countrycode;
                            objCustomer.Creationdate = data1.Creationdate;
                            objCustomer.Modificationdate = data1.Modificationdate;
                            objCustomer.Usercode = data1.Usercode;
                            objCustomer.Deleted = data1.Deleted;
                            objCustomer.Editable = data1.Editable;



                            _poContext12.TmStateMasters.Update(objCustomer);
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

                    var data1 = (TmStateMaster)data.Detail.SingleOrDefault();

                   
                    TmStateMaster objCustomer = new TmStateMaster();

                    objCustomer.Statecode = Convert.ToInt32(data1.Statecode);
                    //objCustomer.Rid = 0;

                        _poContext12.TmStateMasters.Remove(objCustomer);

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



        } // ok

        public async Task<IQueryable<ResponseData<string>>> CMSupplierMaster(ResponseData<TmSupplierMaster> data, string triger)
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

                            var data1 = (TmSupplierMaster)data.Detail.SingleOrDefault();
                            TmSupplierMaster objCustomer = new TmSupplierMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();



                            objCustomer.Id = _poContext12.TmSupplierMasters.Select(x => x.Id).Max() + 1;
                            objCustomer.SupplierName = data1.SupplierName;
                            objCustomer.Address1 = data1.Address1;
                            objCustomer.Address2 = data1.Address2;
                            objCustomer.Address3 = data1.Address3;
                            objCustomer.ContactPerson = data1.ContactPerson;
                            objCustomer.CmobileNo = data1.CmobileNo;
                            objCustomer.Gst = data1.Gst;
                            objCustomer.RecordStatus = data1.RecordStatus;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.TmSupplierMasters.Add(objCustomer);
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




                            var data1 = (TmSupplierMaster)data.Detail.SingleOrDefault();
                            TmSupplierMaster objCustomer = new TmSupplierMaster();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.Id = data1.Id;
                            objCustomer.SupplierName = data1.SupplierName;
                            objCustomer.Address1 = data1.Address1;
                            objCustomer.Address2 = data1.Address2;
                            objCustomer.Address3 = data1.Address3;
                            objCustomer.ContactPerson = data1.ContactPerson;
                            objCustomer.CmobileNo = data1.CmobileNo;
                            objCustomer.Gst = data1.Gst;
                            objCustomer.RecordStatus = data1.RecordStatus;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;



                            _poContext12.TmSupplierMasters.Update(objCustomer);
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

                    var data1 = (TmSupplierMaster)data.Detail.SingleOrDefault();

                    TmSupplierMaster objCustomer = new TmSupplierMaster();

                    objCustomer.Id = Convert.ToInt32(data1.Id);
                    //objCustomer.Rid = 0;

                 
                        _poContext12.TmSupplierMasters.Remove(objCustomer);

                   
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



        } //ok

        //--------------------------------------------------------End Modules----------------------------------------------//
        #endregion
        //---------------------------------------------------File Uplode ------------------------------------------//
        public async Task<IQueryable<ResponseData<string>>> UploadFileAsync(IFile files)
        {
            try
            {


                await using var stream = files.OpenReadStream();

                var streamWriter = new FileStream("./test.zip", FileMode.OpenOrCreate);

                await stream.CopyToAsync(streamWriter);

                //  GlobalData.me.CoverPhotoLength = stream.Length;

                // return GlobalData.me.CoverPhotoLength;


                //var fileName = files.Name;
                //var fileSize = files.Length;
                //await using Stream stream = files.OpenReadStream();
                //var path = Environment.CurrentDirectory;

                //List<IFile> data = new List<IFile>();
                //data.Add(files);


                //List<string> result = new List<string>();

                //Console.WriteLine(data.Count);

                //foreach (var f in data)
                //{
                //    if (f.Length > 0)
                //    {
                //        Directory.CreateDirectory("Resources");
                //        using (var stream1 = new FileStream("./test.zip", FileMode.OpenOrCreate))
                //        {

                //            await f.CopyToAsync(stream1);
                //            result.Add(f.Name);
                //        }
                //    }
                //}





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
