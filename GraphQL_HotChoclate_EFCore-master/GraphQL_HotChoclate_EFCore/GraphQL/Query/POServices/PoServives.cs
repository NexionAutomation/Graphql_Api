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
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        public Task<IQueryable<ExpenseItem>> POExpenseHeadsActual([Service] poContext context)
        {
            try
            {
                List<ExpenseItem> tmUserMaster = context.ExpenseItems.OrderByDescending(x => x.ExpenseId).ToList();
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



        public async Task<IQueryable< ExcelImporter01>> UploadFileExcel(IFile files)
        {
            try
            {



                System.IO.DirectoryInfo di = new DirectoryInfo("FilesData/");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }


                DataTable csvData = new DataTable();




                DataTable csvData2 = new DataTable();


                csvData2.Columns.Add("sno");
                csvData2.Columns.Add("Name");
                csvData2.Columns.Add("Date");
                csvData2.Columns.Add("Day");
                csvData2.Columns.Add("IN");
                csvData2.Columns.Add("OUT");


                var FILENAME = "";
                FileStream streamWriter;
                var ext = "";
                string From1 = "";

                if (files != null)
                {


                    var filename1 = files.Name;
                    var dir1 = "";
                    ext = System.IO.Path.GetExtension(filename1);
                    await using var stream1 = files.OpenReadStream();

                    FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                    streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

                    From1 = streamWriter.Name;


                    await stream1.CopyToAsync(streamWriter);

                    streamWriter.Close();

                    string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

                    //using (var client = new WebClient())
                    //{
                    //    client.Credentials = new NetworkCredential("App", "Nexion@123");
                    //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

                    //}
                }



                List<ExcelImporter01> studentList = new List<ExcelImporter01>();

                var notchange="";


                List<string> Dates=new List<string>();
                List<string> day = new List<string>();
                using (TextFieldParser csvReader = new TextFieldParser(From1))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {

                                

                                fieldData[i] = null;
                            }
                           



                        }
                        csvData.Rows.Add(fieldData);

                    }
                }


                var olddata="";

              
                for (int i = 0; i < csvData.Rows.Count; i++)
                {
                   
                    ExcelImporter01 student = new ExcelImporter01();




                    //olddata = csvData.Rows[i][1].ToString() != "" ? csvData.Rows[i][1].ToString() : olddata;


                          student.T1 = csvData.Rows[i][0].ToString(); 
                          student.T2 = csvData.Rows[i][1].ToString();
                          student.T3 = csvData.Rows[i][2].ToString(); 
                          student.T4 = csvData.Rows[i][3].ToString(); 
                          student.T5 = csvData.Rows[i][4].ToString(); 
                          student.T6 = csvData.Rows[i][5].ToString(); 
                          student.T7 = csvData.Rows[i][6].ToString(); 
                          student.T8 = csvData.Rows[i][7].ToString(); 
                          student.T9 = csvData.Rows[i][8].ToString(); 
                         student.T10 = csvData.Rows[i][9].ToString();
                         student.T11 = csvData.Rows[i][10].ToString(); 
                         student.T12 = csvData.Rows[i][11].ToString(); 
                         student.T13 = csvData.Rows[i][12].ToString(); 
                         student.T14 = csvData.Rows[i][13].ToString(); 
                         student.T15 = csvData.Rows[i][14].ToString(); 
                         student.T16 = csvData.Rows[i][15].ToString(); 
                         student.T17 = csvData.Rows[i][16].ToString(); 
                         student.T18 = csvData.Rows[i][17].ToString(); 
                         student.T19 = csvData.Rows[i][18].ToString(); 
                         student.T20 = csvData.Rows[i][19].ToString(); 
                         student.T21 = csvData.Rows[i][20].ToString(); 
                         student.T22 = csvData.Rows[i][21].ToString(); 
                         student.T23 = csvData.Rows[i][22].ToString(); 
                         student.T24 = csvData.Rows[i][23].ToString(); 
                         student.T25 = csvData.Rows[i][24].ToString(); 
                         student.T26 = csvData.Rows[i][25].ToString(); 
                         student.T27 = csvData.Rows[i][26].ToString(); 
                         student.T28 = csvData.Rows[i][27].ToString(); 
                         student.T29 = csvData.Rows[i][28].ToString(); 
                         student.T30 = csvData.Rows[i][29].ToString(); 
                         student.T31 = csvData.Rows[i][30].ToString(); 
                         student.T32 = csvData.Rows[i][31].ToString(); 
                         student.T33 = csvData.Rows[i][32].ToString(); 
                         student.T34 = csvData.Rows[i][33].ToString(); 
                         student.T35 = csvData.Rows[i][34].ToString(); 
                         student.T36 = csvData.Rows[i][35].ToString(); 
                         student.T37 = csvData.Rows[i][36].ToString(); 
                         student.T38 = csvData.Rows[i][37].ToString(); 
                         student.T39 = csvData.Rows[i][38].ToString(); 
                         student.T40 = csvData.Rows[i][39].ToString(); 
                         student.T41 = csvData.Rows[i][40].ToString(); 
                         student.T42 = csvData.Rows[i][41].ToString(); 
                         student.T43 = csvData.Rows[i][42].ToString(); 
                         student.T44 = csvData.Rows[i][43].ToString(); 
                         student.T45 = csvData.Rows[i][44].ToString(); 
                         student.T46 = csvData.Rows[i][45].ToString(); 
                         student.T47 = csvData.Rows[i][46].ToString(); 
                         student.T48 = csvData.Rows[i][47].ToString(); 
                         student.T49 = csvData.Rows[i][48].ToString(); 
                         student.T50 = csvData.Rows[i][49].ToString(); 

                      



                    studentList.Add(student);
                }



                //csvData


            //var data=   studentList.ToLookup(a=>a.T3,a=>a).ToList();


                //    data.ForEach(a => {


                //        if(a.Key == "DAY")
                //        {
                //            data.ForEach(ab =>
                //            {
                //                day.Add(ab.Key);
                //            });



                //        }



                //    });



                //List<Attandance> dataatt = new List<Attandance>();
                //foreach (var da in data)
                //{


                //    foreach (var dai in da)
                //    {

                //        if(da.Key=="")
                //        {
                //            dataatt.Add(new Attandance
                //            {
                //                Date=dai.

                //            });
                //        }
                //        //dataatt.
                //    }

                //}





                //List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                //ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail:  null, Status: "success");
                //responseDatas2.Add(dat);
                return await Task.Run(() => studentList.AsQueryable());
            }
            catch (Exception ex)
            {


                List<ExcelImporter01> studentList = new List<ExcelImporter01>();
                //ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                //responseDatas2.Add(dat);
                return null;//await Task.Run(() => null);
            }

            finally
            {

            }

        }



        public async Task<IQueryable<ExcelImporter01>> POItemFileUplodeExcel(IFile files)
        {
            try
            {



                System.IO.DirectoryInfo di = new DirectoryInfo("FilesData/");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }


                DataTable csvData = new DataTable();




                DataTable csvData2 = new DataTable();

               
                csvData2.Columns.Add("Cat No");
                csvData2.Columns.Add("Description");
                csvData2.Columns.Add("Make");
                csvData2.Columns.Add("Total Qty");
                csvData2.Columns.Add("Stock Qty");
              


                var FILENAME = "";
                FileStream streamWriter;
                var ext = "";
                string From1 = "";

                if (files != null)
                {


                    var filename1 = files.Name;
                    var dir1 = "";
                    ext = System.IO.Path.GetExtension(filename1);
                    await using var stream1 = files.OpenReadStream();

                    FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                    streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

                    From1 = streamWriter.Name;


                    await stream1.CopyToAsync(streamWriter);

                    streamWriter.Close();

                    string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

                    //using (var client = new WebClient())
                    //{
                    //    client.Credentials = new NetworkCredential("App", "Nexion@123");
                    //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

                    //}
                }



                List<ExcelImporter01> studentList = new List<ExcelImporter01>();

                var notchange = "";


                List<string> Dates = new List<string>();
                List<string> day = new List<string>();
                using (TextFieldParser csvReader = new TextFieldParser(From1))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;

                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {



                                fieldData[i] = null;
                            }




                        }
                        csvData.Rows.Add(fieldData);

                    }
                }


                var olddata = "";


                for (int i = 0; i < csvData.Rows.Count; i++)
                {

                    ExcelImporter01 student = new ExcelImporter01();

                    //olddata = csvData.Rows[i][1].ToString() != "" ? csvData.Rows[i][1].ToString() : olddata;

                    student.T1 = csvData.Rows[i][0].ToString();
                    student.T2 = csvData.Rows[i][1].ToString();
                    student.T3 = csvData.Rows[i][2].ToString();
                    student.T4 = csvData.Rows[i][3].ToString();
                    student.T5 = csvData.Rows[i][4].ToString();
                    //student.T6 = csvData.Rows[i][5].ToString();
                    //student.T7 = csvData.Rows[i][6].ToString();
                    //student.T8 = csvData.Rows[i][7].ToString();
                    //student.T9 = csvData.Rows[i][8].ToString();
                    //student.T10 = csvData.Rows[i][9].ToString();
                    //student.T11 = csvData.Rows[i][10].ToString();
                 
                    studentList.Add(student);
                }



                //csvData


                //var data=   studentList.ToLookup(a=>a.T3,a=>a).ToList();


                //    data.ForEach(a => {


                //        if(a.Key == "DAY")
                //        {
                //            data.ForEach(ab =>
                //            {
                //                day.Add(ab.Key);
                //            });



                //        }



                //    });



                //List<Attandance> dataatt = new List<Attandance>();
                //foreach (var da in data)
                //{


                //    foreach (var dai in da)
                //    {

                //        if(da.Key=="")
                //        {
                //            dataatt.Add(new Attandance
                //            {
                //                Date=dai.

                //            });
                //        }
                //        //dataatt.
                //    }

                //}





                //List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                //ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail:  null, Status: "success");
                //responseDatas2.Add(dat);
                return await Task.Run(() => studentList.AsQueryable());
            }
            catch (Exception ex)
            {


                List<ExcelImporter01> studentList = new List<ExcelImporter01>();
                //ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                //responseDatas2.Add(dat);
                return null;//await Task.Run(() => null);
            }

            finally
            {

            }

        }





        public async Task<IQueryable<ExcelImporter01>> UploadFileExcelAttandance(IFile files)
        {
            try
            {



                System.IO.DirectoryInfo di = new DirectoryInfo("FilesData/");

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }


                DataTable csvData = new DataTable();




                var FILENAME = "";
                FileStream streamWriter;
                var ext = "";
                string From1 = "";

                if (files != null)
                {


                    var filename1 = files.Name;
                    var dir1 = "";
                    ext = System.IO.Path.GetExtension(filename1);
                    await using var stream1 = files.OpenReadStream();

                    FILENAME = DateTime.Now.ToString("ddMMyyyyhhmmss") + ext;
                    streamWriter = new FileStream("FilesData/" + FILENAME, FileMode.OpenOrCreate);

                    From1 = streamWriter.Name;


                    await stream1.CopyToAsync(streamWriter);

                    streamWriter.Close();

                    string To1 = "ftp://182.50.132.58/FileData/" + FILENAME;

                    //using (var client = new WebClient())
                    //{
                    //    client.Credentials = new NetworkCredential("App", "Nexion@123");
                    //    client.UploadFile(To1, WebRequestMethods.Ftp.UploadFile, From1);

                    //}
                }



                using (TextFieldParser csvReader = new TextFieldParser(From1))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }
                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }




                List<ExcelImporter01> studentList = new List<ExcelImporter01>();
                for (int i = 0; i < csvData.Rows.Count; i++)
                {
                    var a = i;
                    ExcelImporter01 student = new ExcelImporter01();



                   if(a >= csvData.Rows.Count){ student.T1 = csvData.Rows[i][0].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T2 = csvData.Rows[i][1].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T3 = csvData.Rows[i][2].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T4 = csvData.Rows[i][3].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T5 = csvData.Rows[i][4].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T6 = csvData.Rows[i][5].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T7 = csvData.Rows[i][6].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T8 = csvData.Rows[i][7].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T9 = csvData.Rows[i][8].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T10 = csvData.Rows[i][9].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T11 = csvData.Rows[i][10].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T12 = csvData.Rows[i][11].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T13 = csvData.Rows[i][12].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T14 = csvData.Rows[i][13].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T15 = csvData.Rows[i][14].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T16 = csvData.Rows[i][15].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T17 = csvData.Rows[i][16].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T18 = csvData.Rows[i][17].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T19 = csvData.Rows[i][18].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T20 = csvData.Rows[i][19].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T21 = csvData.Rows[i][20].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T22 = csvData.Rows[i][21].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T23 = csvData.Rows[i][22].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T24 = csvData.Rows[i][23].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T25 = csvData.Rows[i][24].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T26 = csvData.Rows[i][25].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T27 = csvData.Rows[i][26].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T28 = csvData.Rows[i][27].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T29 = csvData.Rows[i][28].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T30 = csvData.Rows[i][29].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T31 = csvData.Rows[i][30].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T32 = csvData.Rows[i][31].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T33 = csvData.Rows[i][32].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T34 = csvData.Rows[i][33].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T35 = csvData.Rows[i][34].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T36 = csvData.Rows[i][35].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T37 = csvData.Rows[i][36].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T38 = csvData.Rows[i][37].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T39 = csvData.Rows[i][38].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T40 = csvData.Rows[i][39].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T41 = csvData.Rows[i][40].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T42 = csvData.Rows[i][41].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T43 = csvData.Rows[i][42].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T44 = csvData.Rows[i][43].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T45 = csvData.Rows[i][44].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T46 = csvData.Rows[i][45].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T47 = csvData.Rows[i][46].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T48 = csvData.Rows[i][47].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T49 = csvData.Rows[i][48].ToString();  }
                   if(a >= csvData.Rows.Count){ student.T50 = csvData.Rows[i][49].ToString();  }
                    if (a >= csvData.Rows.Count){ student.T51 = csvData.Rows[i][50].ToString();  }

                    studentList.Add(student);
                }





                //List<ResponseData<string>> responseDatas2 = new List<ResponseData<string>>();
                //ResponseData<string> dat = ResponseMSG<string>.Success<List<string>>(Detail:  null, Status: "success");
                //responseDatas2.Add(dat);
                return await Task.Run(() => studentList.AsQueryable());
            }
            catch (Exception ex)
            {


                List<ExcelImporter01> studentList = new List<ExcelImporter01>();
                //ResponseData<string> dat = ResponseMSG<string>.Failed<List<string>>(Detail: null, Status: ex.Message.ToString());
                //responseDatas2.Add(dat);
                return await Task.Run(() => studentList.AsQueryable());
            }

            finally
            {

            }

        }







    }
}
