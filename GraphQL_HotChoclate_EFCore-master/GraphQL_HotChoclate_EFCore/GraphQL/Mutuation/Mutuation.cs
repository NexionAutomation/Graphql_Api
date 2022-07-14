using ExcelDataReader;
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
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
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
                            objCustomer.ModificationDate = DateTime.Now;
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



                    CMAdminSubModuleMaster objCustomer = new CMAdminSubModuleMaster();

                    objCustomer.Rid = Convert.ToInt32(data.ID);

                    _poContext12.CMAdminSubModuleMasters.Remove(objCustomer);
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
        public async Task<IQueryable<ResponseData<string>>> CMExpenseGroupMaster(ResponseData<ExpenseGroup> data, string triger)
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
                           


                            var data1 = (ExpenseGroup)data.Detail.SingleOrDefault();
                            ExpenseGroup objCustomer = new ExpenseGroup();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                            objCustomer.EgroupName = data1.EgroupName;
                            objCustomer.CreatedOn = DateTime.Now;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = DateTime.Now;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.EgroupId = data1.EgroupId;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.ExpenseGroups.Add(objCustomer);
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




                            var data1 = (ExpenseGroup)data.Detail.SingleOrDefault();
                            ExpenseGroup objCustomer = new ExpenseGroup();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();

                         

                            objCustomer.EgroupName = data1.EgroupName;
                            objCustomer.CreatedOn = DateTime.Now;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = DateTime.Now;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.EgroupId = data1.EgroupId;






        _poContext12.ExpenseGroups.Update(objCustomer);
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

                    var data1 = (ExpenseGroup)data.Detail.SingleOrDefault();


                    ExpenseGroup objCustomer = new ExpenseGroup();

                    objCustomer.EgroupId = Convert.ToInt32(data.ID);
                  //  objCustomer.Rid = 0;

                        _poContext12.ExpenseGroups.Remove(objCustomer);

                    
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



                //WebRequest request = WebRequest.Create(host + path);
                //request.Method = WebRequestMethods.Ftp.MakeDirectory;
                //request.Credentials = new NetworkCredential(UserId, Password);
                //using (var resp = (FtpWebResponse)request.GetResponse())
                //{
                //    Console.WriteLine(resp.StatusCode);
                //}


                await using var stream = files.OpenReadStream();

                var streamWriter = new FileStream("./" + DateTime.Now.ToString("ddMMyyyyhhmmss")+".pdf", FileMode.OpenOrCreate);

                await stream.CopyToAsync(streamWriter);

                stream.Close();

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

            finally
            {

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

         public async Task<IQueryable<ResponseData<string>>> CMExpenseHead(ResponseData<ExpenseHead> data, string triger)
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

                            var data1 = (ExpenseHead)data.Detail.SingleOrDefault();
                            ExpenseHead objCustomer = new ExpenseHead();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
                            objCustomer.Title = data1.Title;
                            objCustomer.PeriodForm = data1.PeriodForm;
                            objCustomer.PeriodTo = data1.PeriodTo;
                            objCustomer.WorkOrderId = data1.WorkOrderId;
                            objCustomer.Location = data1.Location;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.ExpenseHeads.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();
                            List<string> DAT = new List<string>();
                            var DATA= Convert.ToString( _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max());
                            DAT.Add(DATA);
                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: DAT, Status: "INSERT");
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




                            var data1 = (ExpenseHead)data.Detail.SingleOrDefault();
                            ExpenseHead objCustomer = new ExpenseHead();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.Title = data1.Title;
                           objCustomer.PeriodForm = data1.PeriodForm;
                            objCustomer.PeriodTo = data1.PeriodTo;
                           objCustomer.WorkOrderId = data1.WorkOrderId;
                           objCustomer.Location = data1.Location;
                            objCustomer.CreatedOn = data1.CreatedOn;
                           objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;



        _poContext12.ExpenseHeads.Update(objCustomer);
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

                    var data1 = (ExpenseHead)data.Detail.SingleOrDefault();

                    ExpenseHead objCustomer = new ExpenseHead();

                    objCustomer.ExpenseId = Convert.ToInt32(data1.ExpenseId);
                    //objCustomer.Rid = 0;

                 
                        _poContext12.ExpenseHeads.Remove(objCustomer);

                   
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

        public async Task<IQueryable<ResponseData<string>>> CMExpenseItem(ResponseData<ExpenseItem> data, string triger)
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

                            var data1 = (ExpenseItem)data.Detail.SingleOrDefault();
                            ExpenseItem objCustomer = new ExpenseItem();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            //objCustomer.ExpenseId = _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.Date = data1.Date;
                            objCustomer.ExpenseTypeId = data1.ExpenseTypeId;
                            objCustomer.Amount = data1.Amount;
                            objCustomer.ApprovedAmount = data1.ApprovedAmount;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Description = data1.Description;
                            objCustomer.PaidBy = data1.PaidBy;
                            objCustomer.Distance = data1.Distance;
                            objCustomer.ParkingAmt = data1.ParkingAmt;
                            objCustomer.Amt = data1.Amt;
                            objCustomer.ExpenseItemsId = 0;//_poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.ExpenseItems.Add(objCustomer);
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




                            var data1 = (ExpenseItem)data.Detail.SingleOrDefault();
                            ExpenseItem objCustomer = new ExpenseItem();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.Date = data1.Date;
                            objCustomer.ExpenseTypeId = data1.ExpenseTypeId;
                            objCustomer.Amount = data1.Amount;
                            objCustomer.ApprovedAmount = data1.ApprovedAmount;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Description = data1.Description;
                            objCustomer.PaidBy = data1.PaidBy;
                            objCustomer.Distance = data1.Distance;
                            objCustomer.ParkingAmt = data1.ParkingAmt;
                            objCustomer.Amt = data1.Amt;
                            objCustomer.ExpenseItemsId = data1.ExpenseItemsId;// _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;



                            _poContext12.ExpenseItems.Update(objCustomer);
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

                    var data1 = (ExpenseItem)data.Detail.SingleOrDefault();

                    ExpenseItem objCustomer = new ExpenseItem();

                    objCustomer.ExpenseItemsId = Convert.ToInt32(data1.ExpenseItemsId);
                    //objCustomer.Rid = 0;


                    _poContext12.ExpenseItems.Remove(objCustomer);


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

        public async Task<IQueryable<ResponseData<string>>> CMExpenseStatusState(ResponseData<ExpenseStatusState> data, string triger)
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

                            var data1 = (ExpenseStatusState)data.Detail.SingleOrDefault();
                            ExpenseStatusState objCustomer = new ExpenseStatusState();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            //objCustomer.ExpenseId = _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.StatusId = data1.StatusId;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Comments = data1.Comments;
                            objCustomer.Rid = 0;//_poContext12.ExpenseStatusStates.Select(x => x.Rid).Max() + 1;
                                     // objCustomer.Rid= data1.Rid;





        _poContext12.ExpenseStatusStates.Add(objCustomer);
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




                            var data1 = (ExpenseStatusState)data.Detail.SingleOrDefault();
                            ExpenseStatusState objCustomer = new ExpenseStatusState();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.StatusId = data1.StatusId;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.UpdateOn = data1.UpdateOn;
                            objCustomer.UpdateBy = data1.UpdateBy;
                            objCustomer.Comments = data1.Comments;
                            objCustomer.Rid = data1.Rid;// _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;



                            _poContext12.ExpenseStatusStates.Update(objCustomer);
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

                    var data1 = (ExpenseStatusState)data.Detail.SingleOrDefault();

                    ExpenseStatusState objCustomer = new ExpenseStatusState();

                    objCustomer.Rid = Convert.ToInt32(data1.Rid);
                    //objCustomer.Rid = 0;


                    _poContext12.ExpenseStatusStates.Remove(objCustomer);


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

        public async Task<IQueryable<ResponseData<string>>> CMExpenseItemAttachment07(ResponseData<ExpenseItemAttachment07> data, string triger,IFile file)
        {

            try
            {


                //await using var stream = file.OpenReadStream();

                //var streamWriter = new FileStream("./test.zip", FileMode.OpenOrCreate);

                //await stream.CopyToAsync(streamWriter);


                //---------------------------------------------------------File remove old Files
                //System.IO.DirectoryInfo di = new DirectoryInfo("FilesData/");

                //foreach (FileInfo filed in di.GetFiles())
                //{
                //    filed.Delete();
                //}

                //---------------------------------------------------------File remove old Files



                var FILENAME ="";
                FileStream streamWriter;
                var ext = "";

                if (triger!="DELETE")
                { 
                

                var filename = file.Name;
                var dir = "";
                 ext = Path.GetExtension(filename);
                await using var stream = file.OpenReadStream();

                 FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                 streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

                string From = streamWriter.Name;


                await stream.CopyToAsync(streamWriter);

                streamWriter.Close();

                string To = "ftp://182.50.132.58/FileData/" + FILENAME;

                using (var client = new WebClient())
                {
                    client.Credentials = new NetworkCredential("App", "Nexion@123");
                    client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, From);

                }
                }


                List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();

                if (triger == "INSERT")
                {
                    using (var dbContextTransaction1 = _poContext12.Database.BeginTransaction())
                    {
                        try
                        {

                            var data1 = (ExpenseItemAttachment07)data.Detail.SingleOrDefault();
                            ExpenseItemAttachment objCustomer = new ExpenseItemAttachment();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = data1.ExpenseId;
     objCustomer.Name = FILENAME;
       objCustomer.ContentType = ext;
                           // objCustomer.Data =
      objCustomer.ImagDescription = data1.ImagDescription;
        objCustomer.CreatedBy = data1.CreatedBy;
      objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.AttchmentId = 0;//data1.AttchmentId;


        //objCustomer.ExpenseId = _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
        //objCustomer.ExpenseId = data1.ExpenseId;
        //objCustomer.StatusId = data1.StatusId;
        //objCustomer.CreatedOn = data1.CreatedOn;
        //objCustomer.CreatedBy = data1.CreatedBy;
        //objCustomer.UpdateOn = data1.UpdateOn;
        //objCustomer.UpdateBy = data1.UpdateBy;
        //objCustomer.Comments = data1.Comments;
        //objCustomer.Rid = 0;//_poContext12.ExpenseStatusStates.Select(x => x.Rid).Max() + 1;
        // objCustomer.Rid= data1.Rid;





                            _poContext12.ExpenseItemAttachments.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();


                            dbContextTransaction1.Commit();



                          

                            //dir = "./"+;

                      

                            



                            //@"D:\PO.xlsx";//streamWriter.Name;
                            //string To = "ftp://199.102.48.4/"+ DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                           







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




                            var data1 = (ExpenseItemAttachment07)data.Detail.SingleOrDefault();
                            ExpenseItemAttachment objCustomer = new ExpenseItemAttachment();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.ExpenseId = data1.ExpenseId;
                            objCustomer.Name = data1.Name;
                            objCustomer.ContentType = data1.ContentType;
                            // public byte[] Data
                            objCustomer.ImagDescription = data1.ImagDescription;
                            objCustomer.CreatedBy = data1.CreatedBy;
                            objCustomer.CreatedOn = data1.CreatedOn;
                            objCustomer.AttchmentId = data1.AttchmentId;// _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;



                            _poContext12.ExpenseItemAttachments.Update(objCustomer);
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

                    var data1 = (ExpenseItemAttachment07)data.Detail.SingleOrDefault();

                    ExpenseItemAttachment objCustomer = new ExpenseItemAttachment();

                    objCustomer.AttchmentId = Convert.ToInt32(data1.AttchmentId);
                    //objCustomer.Rid = 0;


                    _poContext12.ExpenseItemAttachments.Remove(objCustomer);


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

      

        //===========================================================po Module--------------------------------------------------


        public async Task<IQueryable<ResponseData<string>>> CMTmPurchaseHead(ResponseData<TmPurchaseHead> data, string triger)
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

                            var data1 = (TmPurchaseHead)data.Detail.SingleOrDefault();
                            TmPurchaseHead objCustomer = new TmPurchaseHead();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            //objCustomer.ExpenseId = _poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max() + 1;
                            objCustomer.PoId = _poContext12.TmPurchaseHeads.Select(x => x.PoId).Max() + 1;
                            objCustomer.CompanyId = data1.CompanyId;
                            objCustomer.SupplierId = data1.SupplierId;
                            objCustomer.OrderDate = data1.OrderDate;
                            objCustomer.PaymentTerms = data1.PaymentTerms;
                            objCustomer.IndentNo = data1.IndentNo;
                            objCustomer.FreightTerms = data1.FreightTerms;
                            objCustomer.WorkOrderNo = data1.WorkOrderNo;
                            objCustomer.Gst = data1.Gst;
                            objCustomer.DeliveryDate = data1.DeliveryDate;
                            objCustomer.Remarks = data1.Remarks;
                            objCustomer.Total = data1.Total;
                            objCustomer.Enduser = data1.Enduser;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.DeliveryMode = data1.DeliveryMode;
                            objCustomer.Id = _poContext12.TmPurchaseHeads.Select(x => x.Id).Max() + 1;
        // objCustomer.Rid= data1.Rid;





        _poContext12.TmPurchaseHeads.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();
                            List<string> DAT = new List<string>();
                            var DATA = Convert.ToString(_poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max());
                            DAT.Add(DATA);
                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: DAT, Status: "INSERT");
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




                            var data1 = (TmPurchaseHead)data.Detail.SingleOrDefault();
                            TmPurchaseHead objCustomer = new TmPurchaseHead();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.PoId = data1.PoId;
                            objCustomer.CompanyId = data1.CompanyId;
                            objCustomer.SupplierId = data1.SupplierId;
                            objCustomer.OrderDate = data1.OrderDate;
                            objCustomer.PaymentTerms = data1.PaymentTerms;
                            objCustomer.IndentNo = data1.IndentNo;
                            objCustomer.FreightTerms = data1.FreightTerms;
                            objCustomer.WorkOrderNo = data1.WorkOrderNo;
                            objCustomer.Gst = data1.Gst;
                            objCustomer.DeliveryDate = data1.DeliveryDate;
                            objCustomer.Remarks = data1.Remarks;
                            objCustomer.Total = data1.Total;
                            objCustomer.Enduser = data1.Enduser;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.DeliveryMode = data1.DeliveryMode;
                            objCustomer.Id = data1.Id;



                            _poContext12.TmPurchaseHeads.Update(objCustomer);
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

                    var data1 = (TmPurchaseHead)data.Detail.SingleOrDefault();

                    TmPurchaseHead objCustomer = new TmPurchaseHead();

                    objCustomer.PoId = Convert.ToInt32(data1.PoId);
                    //objCustomer.Rid = 0;


                    _poContext12.TmPurchaseHeads.Remove(objCustomer);


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


        public async Task<IQueryable<ResponseData<string>>> CMTmPurchaseBody(ResponseData<TmPurchaseBody> data, string triger)
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

                            var data1 = (TmPurchaseBody)data.Detail.SingleOrDefault();
                            TmPurchaseBody objCustomer = new TmPurchaseBody();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.PoId = data1.PoId;
                             objCustomer.Description = data1.Description;
                           objCustomer.Uom = data1.Uom;
                            objCustomer.Qty = data1.Qty;
                           objCustomer.ListPrice = data1.ListPrice;
                           objCustomer.Dis = data1.Dis;
                           objCustomer.UnitPrice = data1.UnitPrice;
                         objCustomer.NetPrice = data1.NetPrice;
                           objCustomer.CreationDate = data1.CreationDate;
                           objCustomer.CuserId = data1.CuserId;
                          objCustomer.ModificationDate = data1.ModificationDate;
                         objCustomer.MuserId = data1.MuserId;
                            objCustomer.Id = 0;// data1.Id;
                          objCustomer.Catname = data1.Catname;
                            //objCustomer.Id = _poContext12.TmPurchaseHeads.Select(x => x.Id).Max() + 1;
                            // objCustomer.Rid= data1.Rid;





                            _poContext12.TmPurchaseBodies.Add(objCustomer);
                            await _poContext12.SaveChangesAsync();
                            List<string> DAT = new List<string>();
                            var DATA = Convert.ToString(_poContext12.ExpenseHeads.Select(x => x.ExpenseId).Max());
                            DAT.Add(DATA);
                            dbContextTransaction1.Commit();
                            ResponseData<string> dat12 = ResponseMSG<string>.Success<List<string>>(Detail: DAT, Status: "INSERT");
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




                            var data1 = (TmPurchaseBody)data.Detail.SingleOrDefault();
                            TmPurchaseBody objCustomer = new TmPurchaseBody();
                            //objCustomer = (CMAdminSubModuleMaster)data.Detail.SingleOrDefault();


                            objCustomer.PoId = data1.PoId;
                            objCustomer.Description = data1.Description;
                            objCustomer.Uom = data1.Uom;
                            objCustomer.Qty = data1.Qty;
                            objCustomer.ListPrice = data1.ListPrice;
                            objCustomer.Dis = data1.Dis;
                            objCustomer.UnitPrice = data1.UnitPrice;
                            objCustomer.NetPrice = data1.NetPrice;
                            objCustomer.CreationDate = data1.CreationDate;
                            objCustomer.CuserId = data1.CuserId;
                            objCustomer.ModificationDate = data1.ModificationDate;
                            objCustomer.MuserId = data1.MuserId;
                            objCustomer.Id = data1.Id;
                            objCustomer.Catname = data1.Catname;



                            _poContext12.TmPurchaseBodies.Update(objCustomer);
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

                    var data1 = (TmPurchaseBody)data.Detail.SingleOrDefault();

                    TmPurchaseBody objCustomer = new TmPurchaseBody();

                    objCustomer.Id = Convert.ToInt32(data1.Id);
                    //objCustomer.Rid = 0;


                    _poContext12.TmPurchaseBodies.Remove(objCustomer);


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

        //------------------------------------------------------End Po---------------------------------------------



        //---------------------------------------------------File Uplode ------------------------------------------//
        //public async Task<IQueryable<excelviewer>> UploadFileExcel(IFile files)
        //{
        //    try
        //    {



        //        DataTable csvData = new DataTable();




        //        var FILENAME = "";
        //        FileStream streamWriter;
        //        var ext = "";
        //        string From1 = "";

        //        if (files != null)
        //        {


        //            var filename1 = files.Name;
        //            var dir1 = "";
        //            ext = Path.GetExtension(filename1);
        //            await using var stream1 = files.OpenReadStream();

        //            FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //            streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

        //            From1 = streamWriter.Name;


        //            await stream1.CopyToAsync(streamWriter);

        //            streamWriter.Close();

        //            string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

        //            //using (var client = new WebClient())
        //            //{
        //            //    client.Credentials = new NetworkCredential("App", "Nexion@123");
        //            //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

        //            //}
        //        }



        //        using (TextFieldParser csvReader = new TextFieldParser(From1))
        //        {
        //            csvReader.SetDelimiters(new string[] { "," });
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            string[] colFields = csvReader.ReadFields();
        //            foreach (string column in colFields)
        //            {
        //                DataColumn datecolumn = new DataColumn(column);
        //                datecolumn.AllowDBNull = true;
        //                csvData.Columns.Add(datecolumn);
        //            }
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                csvData.Rows.Add(fieldData);
        //            }
        //        }



        //        List<excelviewer> studentList = new List<excelviewer>();
        //        for (int i = 0; i < csvData.Rows.Count; i++)
        //        {
        //            excelviewer student = new excelviewer();
        //            student.T1 = csvData.Rows[i][0].ToString();
        //            student.T2 = csvData.Rows[i][1].ToString();
        //            student.T3 = csvData.Rows[i][1].ToString();
        //            student.T4 = csvData.Rows[i][3].ToString();
        //            student.T5 = csvData.Rows[i][4].ToString();
        //            student.T6 = csvData.Rows[i][5].ToString();
        //            student.T7 = csvData.Rows[i][6].ToString();
        //            student.T8 = csvData.Rows[i][7].ToString();
        //            student.T9 = csvData.Rows[i][8].ToString();
        //            student.T10 = csvData.Rows[i][9].ToString();
        //            student.T11 = csvData.Rows[i][10].ToString();
        //            student.T12 = csvData.Rows[i][11].ToString();
        //            student.T13 = csvData.Rows[i][12].ToString();
        //            student.T14 = csvData.Rows[i][13].ToString();
        //            student.T15 = csvData.Rows[i][14].ToString();

        //            studentList.Add(student);
        //        }





        //        //List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        //ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail:  null, Status: "success");
        //        //responseDatas2.Add(dat);
        //        return await Task.Run(() => studentList.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {


        //        List<excelviewer> studentList = new List<excelviewer>();
        //        //ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
        //        //responseDatas2.Add(dat);
        //        return await Task.Run(() => studentList.AsQueryable());
        //    }

        //    finally
        //    {

        //    }

        //}


        //public async Task<IQueryable<ResponseData<string>>> UploadFileExcel002(IFile files)
        //{
        //    try
        //    {



        //        DataTable csvData = new DataTable();




        //        var FILENAME = "";
        //        FileStream streamWriter;
        //        var ext = "";
        //        string From1 = "";

        //        if (files != null)
        //        {


        //            var filename1 = files.Name;
        //            var dir1 = "";
        //            ext = Path.GetExtension(filename1);
        //            await using var stream1 = files.OpenReadStream();

        //            FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //            streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

        //            From1 = streamWriter.Name;


        //            await stream1.CopyToAsync(streamWriter);

        //            streamWriter.Close();

        //            string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

        //            //using (var client = new WebClient())
        //            //{
        //            //    client.Credentials = new NetworkCredential("App", "Nexion@123");
        //            //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

        //            //}
        //        }



        //        using (TextFieldParser csvReader = new TextFieldParser(From1))
        //        {
        //            csvReader.SetDelimiters(new string[] { "," });
        //            csvReader.HasFieldsEnclosedInQuotes = true;
        //            string[] colFields = csvReader.ReadFields();
        //            foreach (string column in colFields)
        //            {
        //                DataColumn datecolumn = new DataColumn(column);
        //                datecolumn.AllowDBNull = true;
        //                csvData.Columns.Add(datecolumn);
        //            }
        //            while (!csvReader.EndOfData)
        //            {
        //                string[] fieldData = csvReader.ReadFields();
        //                //Making empty value as null
        //                for (int i = 0; i < fieldData.Length; i++)
        //                {
        //                    if (fieldData[i] == "")
        //                    {
        //                        fieldData[i] = null;
        //                    }
        //                }
        //                csvData.Rows.Add(fieldData);
        //            }
        //        }



        //        List<excelviewer> studentList = new List<excelviewer>();
        //        for (int i = 0; i < csvData.Rows.Count; i++)
        //        {
        //            excelviewer student = new excelviewer();
        //            student.T1 = csvData.Rows[i][0].ToString();
        //            student.T2 = csvData.Rows[i][1].ToString();
        //            student.T3 = csvData.Rows[i][1].ToString();
        //            student.T4 = csvData.Rows[i][3].ToString();
        //            student.T5 = csvData.Rows[i][4].ToString();
        //            student.T6 = csvData.Rows[i][5].ToString();
        //            student.T7 = csvData.Rows[i][6].ToString();
        //            student.T8 = csvData.Rows[i][7].ToString();
        //            student.T9 = csvData.Rows[i][8].ToString();
        //            student.T10 = csvData.Rows[i][9].ToString();
        //            student.T11 = csvData.Rows[i][10].ToString();
        //            student.T12 = csvData.Rows[i][11].ToString();
        //            student.T13 = csvData.Rows[i][12].ToString();
        //            student.T14 = csvData.Rows[i][13].ToString();
        //            student.T15 = csvData.Rows[i][14].ToString();

        //            studentList.Add(student);
        //        }






        //        //string cs = @"provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dell\Downloads\05072022012856.xls';Extended Properties=Excel 8.0;";
        //        //DataTable EmployeeTable = new DataTable();
        //        //OleDbConnection con = new OleDbConnection(cs);
        //        //OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1]", con);
        //        //OleDbDataAdapter oda = new OleDbDataAdapter(cmd);
        //        //oda.Fill(EmployeeTable);
        //        // return EmployeeTable;



        //        //WebRequest request = WebRequest.Create(host + path);
        //        //request.Method = WebRequestMethods.Ftp.MakeDirectory;
        //        //request.Credentials = new NetworkCredential(UserId, Password);
        //        //using (var resp = (FtpWebResponse)request.GetResponse())
        //        //{
        //        //    Console.WriteLine(resp.StatusCode);
        //        //}


        //        //var filename= files.Name;
        //        //var dir = "";
        //        //var ext=Path.GetExtension(filename);
        //        //await using var stream = files.OpenReadStream();


        //        //var streamWriter = new FileStream("FilesData/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ext, FileMode.OpenOrCreate);

        //        //string From = streamWriter.Name;

        //        //dir = "./"+;

        //        // await stream.CopyToAsync(streamWriter);

        //        //streamWriter.Close();



        //        ////@"D:\PO.xlsx";//streamWriter.Name;
        //        ////string To = "ftp://199.102.48.4/"+ DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
        //        //string To = "ftp://182.50.132.58/FileData/" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;

        //        //using (var client = new WebClient())
        //        //    {
        //        //        client.Credentials = new NetworkCredential("App", "Nexion@123");
        //        //        client.UploadFile(To, WebRequestMethods.Ftp.UploadFile, From);

        //        //    }










        //        //FtpWebRequest Request = (FtpWebRequest)WebRequest.Create("ftp://");

        //        //Request.Method = WebRequestMethods.Ftp.UploadFile;
        //        //Request.Credentials = new NetworkCredential("user", "pass");
        //        //FtpWebResponse Response = (FtpWebResponse)Request.GetResponse();

        //        //Stream ResponseStream = Response.GetResponseStream();
        //        //StreamReader Reader = new StreamReader(ResponseStream);

        //        ////FileInfo[] Files = directoru.GetFiles("*.txt");

        //        ////ListBox1.Items.Add(Response.WelcomeMessage);

        //        ////while (!Reader.EndOfStream)//Read file name   
        //        ////{
        //        ////    ListBox1.Items.Add(Reader.ReadLine().ToString());
        //        ////}
        //        //Response.Close();
        //        //ResponseStream.Close();
        //        //Reader.Close();


        //        //string fullPathToExcel = "./"+ streamWriter.Name; //ie C:\Temp\YourExcel.xls
        //        //string connString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 12.0;HDR=yes'", fullPathToExcel);
        //        //DataTable dt = GetDataTable("SELECT * from [Sheet1]", connString);

        //        //foreach (DataRow dr in dt.Rows)
        //        //{
        //        //    //Do what you need to do with your data here
        //        //}








        //        //  GlobalData.me.CoverPhotoLength = stream.Length;

        //        // return GlobalData.me.CoverPhotoLength;


        //        //var fileName = files.Name;
        //        //var fileSize = files.Length;
        //        //await using Stream stream = files.OpenReadStream();
        //        //var path = Environment.CurrentDirectory;

        //        //List<IFile> data = new List<IFile>();
        //        //data.Add(files);


        //        //List<string> result = new List<string>();

        //        //Console.WriteLine(data.Count);

        //        //foreach (var f in data)
        //        //{
        //        //    if (f.Length > 0)
        //        //    {
        //        //        Directory.CreateDirectory("Resources");
        //        //        using (var stream1 = new FileStream("./test.zip", FileMode.OpenOrCreate))
        //        //        {

        //        //            await f.CopyToAsync(stream1);
        //        //            result.Add(f.Name);
        //        //        }
        //        //    }
        //        //}





        //        //using (var writer = File.Create("C:\\"))
        //        //{

        //        //    await stream.CopyToAsync(writer).ConfigureAwait(false);
        //        //}

        //        List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail: null, Status: "success");
        //        responseDatas2.Add(dat);
        //        return await Task.Run(() => responseDatas2.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {

        //        List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
        //        ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
        //        responseDatas2.Add(dat);
        //        return await Task.Run(() => responseDatas2.AsQueryable());
        //    }

        //    finally
        //    {

        //    }

        //}




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
