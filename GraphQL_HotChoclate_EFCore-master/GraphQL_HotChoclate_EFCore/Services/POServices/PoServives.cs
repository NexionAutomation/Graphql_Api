using GraphQl.Api.Services;
using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
using GraphQl.DATA.API.PO.Model;
using GraphQL_HotChoclate_EFCore.Models;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace GraphQL_HotChoclate_EFCore.Services
{
    public partial class PoUserServices  //:IPOCRUD
    {
        public readonly ILogger Logger;
        public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED;
        public readonly poContext _poContextData;



        public PoUserServices(ILogger<PoUserServices> logger, poContext poContext2)
        {
            Logger = logger;

            this._poContextData = poContext2;
        }

        [UseFirstOrDefault]
        [UseFiltering(typeof(TmAdminModuleMaster))]
        [UseSorting]
        public Task<IQueryable<ResponseData<TmAdminModuleMaster>>> AdmiModuleMasterData([Service] poContext collection)
        {
            try
            {

                List<ResponseData<TmAdminModuleMaster>> responseDatas2 = new List<ResponseData<TmAdminModuleMaster>>();
                List<TmAdminModuleMaster> tmUserMaster = collection.TmAdminModuleMasters.Select(a => a).ToList();
                ResponseData<TmAdminModuleMaster> dat = ResponseMSG<TmAdminModuleMaster>.Success<List<TmAdminModuleMaster>>(Detail: tmUserMaster);
                 responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }


        [UseFirstOrDefault]
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<TmAdminSubModuleMaster>>> AdmiSubModuleMasterData([Service] poContext Data)
        {
            try
            {

                List<ResponseData<TmAdminSubModuleMaster>> responseDatas2 = new List<ResponseData<TmAdminSubModuleMaster>>();
                List<TmAdminSubModuleMaster> tmUserMaster = Data.TmAdminSubModuleMasters.Select(a => a).ToList();
                ResponseData<TmAdminSubModuleMaster> dat = ResponseMSG<TmAdminSubModuleMaster>.Success<List<TmAdminSubModuleMaster>>(Detail: tmUserMaster);
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }

        [UseFirstOrDefault]
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<TmAdminUserRightsMaster>>> AdmiUserRightsMasterData([Service] poContext Data)
        {
            try
            {

                List<ResponseData<TmAdminUserRightsMaster>> responseDatas2 = new List<ResponseData<TmAdminUserRightsMaster>>();
                List<TmAdminUserRightsMaster> tmUserMaster = Data.TmAdminUserRightsMasters.Select(a => a).ToList();
                ResponseData<TmAdminUserRightsMaster> dat = ResponseMSG<TmAdminUserRightsMaster>.Success<List<TmAdminUserRightsMaster>>(Detail: tmUserMaster);
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }

        [UseFirstOrDefault]
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<Automumber1>>> Automumber1Data([Service] poContext Data)
        {
            try
            {

                List<ResponseData<Automumber1>> responseDatas2 = new List<ResponseData<Automumber1>>();
                List<Automumber1> tmUserMaster = Data.Automumbers1.Select(a => a).ToList();
                ResponseData<Automumber1> dat = ResponseMSG<Automumber1>.Success<List<Automumber1>>(Detail: tmUserMaster);
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }

        [UseFirstOrDefault]
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<Automumber>>> AutomumberData([Service]poContext Data)
        {
            try
            {

                List<ResponseData<Automumber>> responseDatas2 = new List<ResponseData<Automumber>>();
                List<Automumber> tmUserMaster = Data.Automumbers.Select(a => a).ToList();
                ResponseData<Automumber> dat = ResponseMSG<Automumber>.Success<List<Automumber>>(Detail: tmUserMaster);
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ChartstempTable1>>> ChartstempTable1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ChartstempTable>>> ChartstempTableData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmCityMaster>>> CityMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmCompanyMaster>>> CompayMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}
        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmCountryMaster>>> CoutryMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmDashboard1>>> Dashboard1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwDashBoard1>>> DashBoard1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmDashboard>>> DashboardData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwDashBoard>>> DashBoardData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempBankDetail1>>> empBakDetail1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempBankDetail>>> empBakDetailData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempDocumentUplode1>>> empDocumetUplode1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempDocumentUplode>>> empDocumetUplodeData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempEmrcontacttwo1>>> empEmrcotacttwo1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempEmrcontacttwo>>> empEmrcotacttwoData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempEmrdetail1>>> empEmrdetail1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<NempEmrdetail>>> empEmrdetailData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempPersonalDetail1>>> empPersoalDetail1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<NempPersonalDetail>>> empPersoalDetailData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseGroup>>> ExpeseGroupData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseHead>>> ExpeseHeadData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseItemAttachment1>>> ExpeseItemAttachmet1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseItemAttachment2>>> ExpeseItemAttachmet2Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseItemAttachment>>> ExpeseItemAttachmetData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseItem>>> ExpeseItemData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<ExpenseStatusMaster>>> ExpeseStatusMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseStatusState>>> ExpeseStatusStateData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<ExpenseType>>> ExpeseTypeData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmFinaicalYear>>> FiaicalYearData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<TmGroupMaster>>> GroupMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LempColorMaster>>> LempColorMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LempLeaveEmp>>> LempLeaveEmpData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LempLeavemaster>>> LempLeavemasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IQueryable<ResponseData<LempLeaveSetting>>> LempLeaveSettigData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LempStatusmaster>>> LempStatusmasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwLocalDashBoardDatum1>>> LocalDashBoardDatum1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwLocalDashBoardDatum>>> LocalDashBoardDatumData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwLocalExpense1>>> LocalExpese1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwLocalExpenseComment1>>> LocalExpeseCommet1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwLocalExpenseComment>>> LocalExpeseCommetData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwLocalExpense>>> LocalExpeseData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LocalExpenseHead>>> LocalExpeseHeadData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<LocalExpenseItem>>> LocalExpeseItemData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<LocalExpenseStatusState>>> LocalExpeseStatusStateData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwOutStationDashBoardDatum1>>> OutStatioDashBoardDatum1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwOutStationDashBoardDatum>>> OutStatioDashBoardDatumData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwOutStationExpense1>>> OutStatioExpese1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwOutstationExpenseComment1>>> OutstatioExpeseCommet1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<VwOutstationExpenseComment>>> OutstatioExpeseCommetData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<VwOutStationExpense>>> OutStatioExpeseData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmPurchaseBody>>> PurchaseBodyData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmPurchaseHead>>> PurchaseHeadData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]
        //public Task<IQueryable<ResponseData<TmStateMaster>>> StateMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        ////[UseFirstOrDefault]
        ////[UseFiltering]
        ////[UseSorting]

        //public Task<IQueryable<ResponseData<TmSupplierMaster>>> SupplierMasterData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}


        [UseFirstOrDefault]
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ResponseData<TblFile>>> TblFileData([Service]poContext Data)
        {
            try
            {

                List<ResponseData<TblFile>> responseDatas2 = new List<ResponseData<TblFile>>();
                List<TblFile> tmUserMaster = Data.TblFiles.Select(a => a).ToList();
                ResponseData<TblFile> dat = ResponseMSG<TblFile>.Success<List<TblFile>>(Detail: tmUserMaster);
                responseDatas2.Add(dat);

                return Task.Run(() => responseDatas2.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null;
            }
        }

        //public Task<IQueryable<ResponseData<TransportType>>> TrasportTypeData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IQueryable<ResponseData<TransporttypeVsRate1>>> TrasporttypeVsRate1Data(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IQueryable<ResponseData<TransporttypeVsRate>>> TrasporttypeVsRateData(poContext Data)
        //{
        //    throw new NotImplementedException();
        //}

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmUserMaster>> UserMasterData([Service] poContext Data,IResolverContext context)
        {
            try
            {
                List<ResponseData<TmUserMaster>> responseDatas2 = new List<ResponseData<TmUserMaster>>();
                List<TmUserMaster> tmUserMaster = _poContextData.TmUserMasters.Select(a => a).ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
                return null ;
            }
        }

        //[SubscribeAndResolve]
        //public async ValueTask<IQueryable<ResponseData<TmUserMaster>>> OnDepartmentCreate([Service] poContext  eventReceiver, CancellationToken cancellationToken)
        //{
        //    return await eventReceiver.su<string, Department>("DepartmentCreated", cancellationToken);
        //}




        //[UseFirstOrDefault]
        //[UseFiltering]
        //[UseSorting]

        //public Task<IQueryable<ResponseData<TmUserMaster>>> Create([Service] poContext collection)
        //{
        //    try
        //    {

        //        List<ResponseData<TmUserMaster>> responseDatas2 = new List<ResponseData<TmUserMaster>>();
        //        List<TmUserMaster> tmUserMaster = collection.TmUserMasters.Select(a => a).ToList();
        //        ResponseData<TmUserMaster> dat = ResponseMSG<TmUserMaster>.Success<List<TmUserMaster>>(Detail: tmUserMaster);
        //        //res
        //        //ResponseData<ResponseStatus> dat = ResponseMSG<ResponseStatus>.Success<List<ResponseStatus>>(Detail: ResponseStatus.Status="hello".ToList());
        //        responseDatas2.Add(dat);

        //        return Task.Run(() => responseDatas2.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
        //        return null;
        //    }
        //}

        //[UseFirstOrDefault]

        //[UseFiltering]
        //[UseSorting]

        //public Task<IQueryable<ResponseData<TmCityMaster>>> Create2([Service] poContext collection)
        //{
        //    try
        //    {

        //        List<ResponseData<TmCityMaster>> responseDatas2 = new List<ResponseData<TmCityMaster>>();
        //        List<TmCityMaster> tmUserMaster = collection.TmCityMasters.Select(a => a).ToList();
        //        ResponseData<TmCityMaster> dat = ResponseMSG<TmCityMaster>.Success<List<TmCityMaster>>(Detail: tmUserMaster);
        //        //res
        //        //ResponseData<ResponseStatus> dat = ResponseMSG<ResponseStatus>.Success<List<ResponseStatus>>(Detail: ResponseStatus.Status="hello".ToList());
        //        responseDatas2.Add(dat);

        //        return Task.Run(() => responseDatas2.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        //responseDatas.Add(new ResponseData { Message = CustomMSGStatus.Fail, Code = ex.Source, Detail = new ResponseData { Message = ex.Message.ToString() }, ID = Guid.NewGuid().ToString(), Status = "Success" }) ;
        //        return null;
        //    }
        //}






    }
}
