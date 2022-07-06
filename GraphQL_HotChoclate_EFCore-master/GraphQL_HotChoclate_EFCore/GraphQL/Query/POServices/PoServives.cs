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
using Microsoft.EntityFrameworkCore;
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
        public readonly ILogger Logger12;
        public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED12;
        public readonly poContext _poContext12;



        //public PoUserServices(ILogger<PoUserServices> logger)
        //{
        //    Logger = logger;

        //    //CURED = cRUD;
        //}

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Automumber>> POAutomumbers([Service] poContext context)
        {
            try
            {
                List<Automumber> tmUserMaster = context.Automumbers.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Automumber1>> POAutomumbers1([Service] poContext context)
        {
            try
            {
                List<Automumber1> tmUserMaster = context.Automumbers1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ChartstempTable>> POChartstempTables([Service] poContext context)
        {
            try
            {
                List<ChartstempTable> tmUserMaster = context.ChartstempTables.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ChartstempTable1>> POChartstempTables1([Service] poContext context)
        {
            try
            {
                List<ChartstempTable1> tmUserMaster = context.ChartstempTables1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseGroup>> POExpenseGroups([Service] poContext context)
        {
            try
            {
                List<ExpenseGroup> tmUserMaster = context.ExpenseGroups.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutStationExpense>> POExpenseHeads([Service] poContext context)
        {
            try
            {
                List<VwOutStationExpense> tmUserMaster = context.VwOutStationExpenses.OrderByDescending(x=>x.ExpenseId).ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseItem>> POExpenseItems([Service] poContext context)
        {
            try
            {
                List<ExpenseItem> tmUserMaster = context.ExpenseItems.OrderByDescending(x=>x.ExpenseItemsId).ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseItemAttachment>> POExpenseItemAttachments([Service] poContext context)
        {
            try
            {
                List<ExpenseItemAttachment> tmUserMaster = context.ExpenseItemAttachments.OrderByDescending(x=>x.AttchmentId).ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseItemAttachment1>> POExpenseItemAttachment1s([Service] poContext context)
        {
            try
            {
                List<ExpenseItemAttachment1> tmUserMaster = context.ExpenseItemAttachment1s.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseItemAttachment2>> POExpenseItemAttachments1([Service] poContext context)
        {
            try
            {
                List<ExpenseItemAttachment2> tmUserMaster = context.ExpenseItemAttachments1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseStatusMaster>> POExpenseStatusMasters([Service] poContext context)
        {
            try
            {
                List<ExpenseStatusMaster> tmUserMaster = context.ExpenseStatusMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseStatusState>> POExpenseStatusStates([Service] poContext context)
        {
            try
            {
                List<ExpenseStatusState> tmUserMaster = context.ExpenseStatusStates.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ExpenseType>> POExpenseTypes([Service] poContext context)
        {
            try
            {
                List<ExpenseType> tmUserMaster = context.ExpenseTypes.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LempColorMaster>> POLempColorMasters([Service] poContext context)
        {
            try
            {
                List<LempColorMaster> tmUserMaster = context.LempColorMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LempLeaveEmp>> POLempLeaveEmps([Service] poContext context)
        {
            try
            {
                List<LempLeaveEmp> tmUserMaster = context.LempLeaveEmps.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LempLeaveSetting>> POLempLeaveSettings([Service] poContext context)
        {
            try
            {
                List<LempLeaveSetting> tmUserMaster = context.LempLeaveSettings.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LempLeavemaster>> POLempLeavemasters([Service] poContext context)
        {
            try
            {
                List<LempLeavemaster> tmUserMaster = context.LempLeavemasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LempStatusmaster>> POLempStatusmasters([Service] poContext context)
        {
            try
            {
                List<LempStatusmaster> tmUserMaster = context.LempStatusmasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LocalExpenseHead>> POLocalExpenseHeads([Service] poContext context)
        {
            try
            {
                List<LocalExpenseHead> tmUserMaster = context.LocalExpenseHeads.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LocalExpenseItem>> POLocalExpenseItems([Service] poContext context)
        {
            try
            {
                List<LocalExpenseItem> tmUserMaster = context.LocalExpenseItems.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LocalExpenseStatusState>> POLocalExpenseStatusStates([Service] poContext context)
        {
            try
            {
                List<LocalExpenseStatusState> tmUserMaster = context.LocalExpenseStatusStates.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempBankDetail>> PONempBankDetails([Service] poContext context)
        {
            try
            {
                List<NempBankDetail> tmUserMaster = context.NempBankDetails.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempBankDetail1>> PONempBankDetails1([Service] poContext context)
        {
            try
            {
                List<NempBankDetail1> tmUserMaster = context.NempBankDetails1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempDocumentUplode>> PONempDocumentUplodes([Service] poContext context)
        {
            try
            {
                List<NempDocumentUplode> tmUserMaster = context.NempDocumentUplodes.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempDocumentUplode1>> PONempDocumentUplodes1([Service] poContext context)
        {
            try
            {
                List<NempDocumentUplode1> tmUserMaster = context.NempDocumentUplodes1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempEmrcontacttwo>> PONempEmrcontacttwos([Service] poContext context)
        {
            try
            {
                List<NempEmrcontacttwo> tmUserMaster = context.NempEmrcontacttwos.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempEmrcontacttwo1>> PONempEmrcontacttwos1([Service] poContext context)
        {
            try
            {
                List<NempEmrcontacttwo1> tmUserMaster = context.NempEmrcontacttwos1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempEmrdetail>> PONempEmrdetails([Service] poContext context)
        {
            try
            {
                List<NempEmrdetail> tmUserMaster = context.NempEmrdetails.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempEmrdetail1>> PONempEmrdetails1([Service] poContext context)
        {
            try
            {
                List<NempEmrdetail1> tmUserMaster = context.NempEmrdetails1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempPersonalDetail>> PONempPersonalDetails([Service] poContext context)
        {
            try
            {
                List<NempPersonalDetail> tmUserMaster = context.NempPersonalDetails.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<NempPersonalDetail1>> PONempPersonalDetails1([Service] poContext context)
        {
            try
            {
                List<NempPersonalDetail1> tmUserMaster = context.NempPersonalDetails1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TblFile>> POTblFiles([Service] poContext context)
        {
            try
            {
                List<TblFile> tmUserMaster = context.TblFiles.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmAdminModuleMaster>> POTmAdminModuleMasters([Service] poContext context)
        {
            try
            {
                List<TmAdminModuleMaster> tmUserMaster = context.TmAdminModuleMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmAdminSubModuleMaster>> POTmAdminSubModuleMasters([Service] poContext context)
        {
            try
            {
                List<TmAdminSubModuleMaster> tmUserMaster = context.TmAdminSubModuleMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmAdminUserRightsMaster>> POTmAdminUserRightsMasters([Service] poContext context)
        {
            try
            {
                List<TmAdminUserRightsMaster> tmUserMaster = context.TmAdminUserRightsMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmCityMaster>> POTmCityMasters([Service] poContext context)
        {
            try
            {
                List<TmCityMaster> tmUserMaster = context.TmCityMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmCompanyMaster>> POTmCompanyMasters([Service] poContext context)
        {
            try
            {
                List<TmCompanyMaster> tmUserMaster = context.TmCompanyMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmCountryMaster>> POTmCountryMasters([Service] poContext context)
        {
            try
            {
                List<TmCountryMaster> tmUserMaster = context.TmCountryMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmDashboard>> POTmDashboards([Service] poContext context)
        {
            try
            {
                List<TmDashboard> tmUserMaster = context.TmDashboards.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmDashboard1>> POTmDashboards1([Service] poContext context)
        {
            try
            {
                List<TmDashboard1> tmUserMaster = context.TmDashboards1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmFinaicalYear>> POTmFinaicalYears([Service] poContext context)
        {
            try
            {
                List<TmFinaicalYear> tmUserMaster = context.TmFinaicalYears.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmGroupMaster>> POTmGroupMasters([Service] poContext context)
        {
            try
            {
                List<TmGroupMaster> tmUserMaster = context.TmGroupMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmPurchaseBody>> POTmPurchaseBodies([Service] poContext context)
        {
            try
            {
                List<TmPurchaseBody> tmUserMaster = context.TmPurchaseBodies.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmPurchaseHead>> POTmPurchaseHeads([Service] poContext context)
        {
            try
            {
                List<TmPurchaseHead> tmUserMaster = context.TmPurchaseHeads.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmStateMaster>> POTmStateMasters([Service] poContext context)
        {
            try
            {
                List<TmStateMaster> tmUserMaster = context.TmStateMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmSupplierMaster>> POTmSupplierMasters([Service] poContext context)
        {
            try
            {
                List<TmSupplierMaster> tmUserMaster = context.TmSupplierMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmUserMaster>> POTmUserMasters([Service] poContext context)
        {
            try
            {
                List<TmUserMaster> tmUserMaster = context.TmUserMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TransportType>> POTransportTypes([Service] poContext context)
        {
            try
            {
                List<TransportType> tmUserMaster = context.TransportTypes.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TransporttypeVsRate>> POTransporttypeVsRates([Service] poContext context)
        {
            try
            {
                List<TransporttypeVsRate> tmUserMaster = context.TransporttypeVsRates.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TransporttypeVsRate1>> POTransporttypeVsRates1([Service] poContext context)
        {
            try
            {
                List<TransporttypeVsRate1> tmUserMaster = context.TransporttypeVsRates1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwDashBoard>> POVwDashBoards([Service] poContext context)
        {
            try
            {
                List<VwDashBoard> tmUserMaster = context.VwDashBoards.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwDashBoard1>> POVwDashBoards1([Service] poContext context)
        {
            try
            {
                List<VwDashBoard1> tmUserMaster = context.VwDashBoards1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalDashBoardDatum>> POVwLocalDashBoardData([Service] poContext context)
        {
            try
            {
                List<VwLocalDashBoardDatum> tmUserMaster = context.VwLocalDashBoardData.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalDashBoardDatum1>> POVwLocalDashBoardData1([Service] poContext context)
        {
            try
            {
                List<VwLocalDashBoardDatum1> tmUserMaster = context.VwLocalDashBoardData1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalExpense>> POVwLocalExpenses([Service] poContext context)
        {
            try
            {
                List<VwLocalExpense> tmUserMaster = context.VwLocalExpenses.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalExpense1>> POVwLocalExpenses1([Service] poContext context)
        {
            try
            {
                List<VwLocalExpense1> tmUserMaster = context.VwLocalExpenses1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalExpenseComment>> POVwLocalExpenseComments([Service] poContext context)
        {
            try
            {
                List<VwLocalExpenseComment> tmUserMaster = context.VwLocalExpenseComments.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwLocalExpenseComment1>> POVwLocalExpenseComments1([Service] poContext context)
        {
            try
            {
                List<VwLocalExpenseComment1> tmUserMaster = context.VwLocalExpenseComments1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutStationDashBoardDatum>> POVwOutStationDashBoardData([Service] poContext context)
        {
            try
            {
                List<VwOutStationDashBoardDatum> tmUserMaster = context.VwOutStationDashBoardData.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutStationDashBoardDatum1>> POVwOutStationDashBoardData1([Service] poContext context)
        {
            try
            {
                List<VwOutStationDashBoardDatum1> tmUserMaster = context.VwOutStationDashBoardData1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutStationExpense>> POVwOutStationExpenses([Service] poContext context)
        {
            try
            {
                List<VwOutStationExpense> tmUserMaster = context.VwOutStationExpenses.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutStationExpense1>> POVwOutStationExpenses1([Service] poContext context)
        {
            try
            {
                List<VwOutStationExpense1> tmUserMaster = context.VwOutStationExpenses1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutstationExpenseComment>> POVwOutstationExpenseComments([Service] poContext context)
        {
            try
            {
                List<VwOutstationExpenseComment> tmUserMaster = context.VwOutstationExpenseComments.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<VwOutstationExpenseComment1>> POVwOutstationExpenseComments1([Service] poContext context)
        {
            try
            {
                List<VwOutstationExpenseComment1> tmUserMaster = context.VwOutstationExpenseComments1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<CMAdminModuleMaster>> CMTmAdminModuleMasters([Service] poContext context)
        {
            try
            {
                List<CMAdminModuleMaster> tmUserMaster = context.CMAdminModuleMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<CMAdminSubModuleMaster>> CMTmAdminSubModuleMasters([Service] poContext context)
        {
            try
            {
                List<CMAdminSubModuleMaster> tmUserMaster = context.CMAdminSubModuleMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<CMWebUserRightsMaster>> CMWebUserRightsMaster([Service] poContext context)
        {
            try
            {
                List<CMWebUserRightsMaster> tmUserMaster = context.CMWebUserRightsMasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }



        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<TmPurchaseHead2>> CMPOFetchdata([Service] poContext context)
        {
            try
            {
                

                List<TmPurchaseHead2> tmUserMaster = context.TmPurchaseHeads2.OrderByDescending(x=>x.PoId).ToList();


               
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }





    }
}
