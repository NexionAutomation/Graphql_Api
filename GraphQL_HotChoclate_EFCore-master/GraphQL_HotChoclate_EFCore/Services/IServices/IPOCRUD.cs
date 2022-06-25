using GraphQl.Api.Utility;
using GraphQl.DATA.API.PO.Model;
using HotChocolate;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Api.Services
{
    public interface IPOCRUD 
    {
        Task<IQueryable<ResponseData<Automumber>>> AutomumberData(poContext Data);
        Task<IQueryable<ResponseData<Automumber1>>> Automumber1Data(poContext Data);
        Task<IQueryable<ResponseData<ChartstempTable>>> ChartstempTableData(poContext Data);
        Task<IQueryable<ResponseData<ChartstempTable1>>> ChartstempTable1Data(poContext Data);
        Task<IQueryable<ResponseData<ExpenseGroup>>> ExpeseGroupData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseHead>>> ExpeseHeadData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseItem>>> ExpeseItemData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseItemAttachment>>> ExpeseItemAttachmetData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseItemAttachment1>>> ExpeseItemAttachmet1Data(poContext Data);
        Task<IQueryable<ResponseData<ExpenseItemAttachment2>>> ExpeseItemAttachmet2Data(poContext Data);
        Task<IQueryable<ResponseData<ExpenseStatusMaster>>> ExpeseStatusMasterData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseStatusState>>> ExpeseStatusStateData(poContext Data);
        Task<IQueryable<ResponseData<ExpenseType>>> ExpeseTypeData(poContext Data);
        Task<IQueryable<ResponseData<LempColorMaster>>> LempColorMasterData(poContext Data);
        Task<IQueryable<ResponseData<LempLeaveEmp>>> LempLeaveEmpData(poContext Data);
        Task<IQueryable<ResponseData<LempLeaveSetting>>> LempLeaveSettigData(poContext Data);
        Task<IQueryable<ResponseData<LempLeavemaster>>> LempLeavemasterData(poContext Data);
        Task<IQueryable<ResponseData<LempStatusmaster>>> LempStatusmasterData(poContext Data);
        Task<IQueryable<ResponseData<LocalExpenseHead>>> LocalExpeseHeadData(poContext Data);
        Task<IQueryable<ResponseData<LocalExpenseItem>>> LocalExpeseItemData(poContext Data);
        Task<IQueryable<ResponseData<LocalExpenseStatusState>>> LocalExpeseStatusStateData(poContext Data);
        Task<IQueryable<ResponseData<NempBankDetail>>> empBakDetailData(poContext Data);
        Task<IQueryable<ResponseData<NempBankDetail1>>> empBakDetail1Data(poContext Data);
        Task<IQueryable<ResponseData<NempDocumentUplode>>> empDocumetUplodeData(poContext Data);
        Task<IQueryable<ResponseData<NempDocumentUplode1>>> empDocumetUplode1Data(poContext Data);
        Task<IQueryable<ResponseData<NempEmrcontacttwo>>> empEmrcotacttwoData(poContext Data);
        Task<IQueryable<ResponseData<NempEmrcontacttwo1>>> empEmrcotacttwo1Data(poContext Data);
        Task<IQueryable<ResponseData<NempEmrdetail>>> empEmrdetailData(poContext Data);
        Task<IQueryable<ResponseData<NempEmrdetail1>>> empEmrdetail1Data(poContext Data);
        Task<IQueryable<ResponseData<NempPersonalDetail>>> empPersoalDetailData(poContext Data);
        Task<IQueryable<ResponseData<NempPersonalDetail1>>> empPersoalDetail1Data(poContext Data);
        Task<IQueryable<ResponseData<TblFile>>> TblFileData(poContext Data);
        Task<IQueryable<ResponseData<TmAdminModuleMaster>>> AdmiModuleMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmAdminSubModuleMaster>>> AdmiSubModuleMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmAdminUserRightsMaster>>> AdmiUserRightsMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmCityMaster>>> CityMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmCompanyMaster>>> CompayMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmCountryMaster>>> CoutryMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmDashboard>>> DashboardData(poContext Data);
        Task<IQueryable<ResponseData<TmDashboard1>>> Dashboard1Data(poContext Data);
        Task<IQueryable<ResponseData<TmFinaicalYear>>> FiaicalYearData(poContext Data);
        Task<IQueryable<ResponseData<TmGroupMaster>>> GroupMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmPurchaseBody>>> PurchaseBodyData(poContext Data);
        Task<IQueryable<ResponseData<TmPurchaseHead>>> PurchaseHeadData(poContext Data);
        Task<IQueryable<ResponseData<TmPurchaseHead2>>> PurchaseHeadData2(poContext Data);
        Task<IQueryable<ResponseData<TmStateMaster>>> StateMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmSupplierMaster>>> SupplierMasterData(poContext Data);
        Task<IQueryable<ResponseData<TmUserMaster>>> UserMasterData(poContext Data);
        Task<IQueryable<ResponseData<TransportType>>> TrasportTypeData(poContext Data);
        Task<IQueryable<ResponseData<TransporttypeVsRate>>> TrasporttypeVsRateData(poContext Data);
        Task<IQueryable<ResponseData<TransporttypeVsRate1>>> TrasporttypeVsRate1Data(poContext Data);
        Task<IQueryable<ResponseData<VwDashBoard>>> DashBoardData(poContext Data);
        Task<IQueryable<ResponseData<VwDashBoard1>>> DashBoard1Data(poContext Data);
        Task<IQueryable<ResponseData<VwLocalDashBoardDatum>>> LocalDashBoardDatumData(poContext Data);
        Task<IQueryable<ResponseData<VwLocalDashBoardDatum1>>> LocalDashBoardDatum1Data(poContext Data);
        Task<IQueryable<ResponseData<VwLocalExpense>>> LocalExpeseData(poContext Data);
        Task<IQueryable<ResponseData<VwLocalExpense1>>> LocalExpese1Data(poContext Data);
        Task<IQueryable<ResponseData<VwLocalExpenseComment>>> LocalExpeseCommetData(poContext Data);
        Task<IQueryable<ResponseData<VwLocalExpenseComment1>>> LocalExpeseCommet1Data(poContext Data);
        Task<IQueryable<ResponseData<VwOutStationDashBoardDatum>>> OutStatioDashBoardDatumData(poContext Data);
        Task<IQueryable<ResponseData<VwOutStationDashBoardDatum1>>> OutStatioDashBoardDatum1Data(poContext Data);
        Task<IQueryable<ResponseData<VwOutStationExpense>>> OutStatioExpeseData(poContext Data);
        Task<IQueryable<ResponseData<VwOutStationExpense1>>> OutStatioExpese1Data(poContext Data);
        Task<IQueryable<ResponseData<VwOutstationExpenseComment>>> OutstatioExpeseCommetData(poContext Data);
        Task<IQueryable<ResponseData<VwOutstationExpenseComment1>>> OutstatioExpeseCommet1Data(poContext Data);


    }
}
