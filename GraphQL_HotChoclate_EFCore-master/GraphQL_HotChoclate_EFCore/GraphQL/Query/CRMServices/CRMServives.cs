using GraphQl.Api.Services;
using GraphQl.Api.Services.IServices;
using GraphQl.Api.Utility;
using GraphQl.Api.Utility.Custom;
using GraphQl.DATA.API.Models;
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
        public readonly ILogger Logger1;
        // public readonly ICRUD<ResponseData<TmUserMaster>, TmUserMaster> CURED;
        public readonly poContext _poContext1;



        //public PoUserServices(ILogger<PoUserServices> logger)
        //{
        //    Logger = logger;

        //    //CURED = cRUD;
        //}

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<User>> CRMUser([Service] crmContext context)
        {
            try
            {
                List<User> tmUserMaster = context.Users.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Account>> CRMAccounts([Service] crmContext context)
        {
            try
            {
                List<Account> tmUserMaster = context.Accounts.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AccountType>> CRMAccountTypes([Service] crmContext context)
        {
            try
            {
                List<AccountType> tmUserMaster = context.AccountTypes.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AspNetRole>> CRMAspNetRoles([Service] crmContext context)
        {
            try
            {
                List<AspNetRole> tmUserMaster = context.AspNetRoles.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AspNetUser>> CRMAspNetUsers([Service] crmContext context)
        {
            try
            {
                List<AspNetUser> tmUserMaster = context.AspNetUsers.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [UseFiltering]
        [UseSorting]
        //public Task<IQueryable<Account>> CRMAccounts([Service] crmContext context)
        //{
        //    try
        //    {
        //        List<Account> tmUserMaster = context.Accounts.ToList();
        //        return Task.Run(() => tmUserMaster.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //[UseFiltering]
        //[UseSorting]
        //public Task<IQueryable<AccountType>> CRMAccountTypes([Service] crmContext context)
        //{
        //    try
        //    {
        //        List<AccountType> tmUserMaster = context.AccountTypes.ToList();
        //        return Task.Run(() => tmUserMaster.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //[UseFiltering]
        //[UseSorting]
        //public Task<IQueryable<AspNetRole>> CRMAspNetRoles([Service] crmContext context)
        //{
        //    try
        //    {
        //        List<AspNetRole> tmUserMaster = context.AspNetRoles.ToList();
        //        return Task.Run(() => tmUserMaster.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //[UseFiltering]
        //[UseSorting]
        //public Task<IQueryable<AspNetUser>> CRMAspNetUsers([Service] crmContext context)
        //{
        //    try
        //    {
        //        List<AspNetUser> tmUserMaster = context.AspNetUsers.ToList();
        //        return Task.Run(() => tmUserMaster.AsQueryable());
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}
        //[UseFiltering]
        //[UseSorting]
        public Task<IQueryable<AspNetUserClaim>> CRMAspNetUserClaims([Service] crmContext context)
        {
            try
            {
                List<AspNetUserClaim> tmUserMaster = context.AspNetUserClaims.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AspNetUserLogin>> CRMAspNetUserLogins([Service] crmContext context)
        {
            try
            {
                List<AspNetUserLogin> tmUserMaster = context.AspNetUserLogins.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AspNetUserRole>> CRMAspNetUserRoles([Service] crmContext context)
        {
            try
            {
                List<AspNetUserRole> tmUserMaster = context.AspNetUserRoles.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<AuditTrailLead>> CRMAuditTrailLeads([Service] crmContext context)
        {
            try
            {
                List<AuditTrailLead> tmUserMaster = context.AuditTrailLeads.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Company>> CRMCompanies([Service] crmContext context)
        {
            try
            {
                List<Company> tmUserMaster = context.Companies.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Configuration>> CRMConfigurations([Service] crmContext context)
        {
            try
            {
                List<Configuration> tmUserMaster = context.Configurations.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Contact>> CRMContacts([Service] crmContext context)
        {
            try
            {
                List<Contact> tmUserMaster = context.Contacts.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Country>> CRMCountries([Service] crmContext context)
        {
            try
            {
                List<Country> tmUserMaster = context.Countries.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Currency>> CRMCurrencies([Service] crmContext context)
        {
            try
            {
                List<Currency> tmUserMaster = context.Currencies.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Industry>> CRMIndustries([Service] crmContext context)
        {
            try
            {
                List<Industry> tmUserMaster = context.Industries.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Lead>> CRMLeads([Service] crmContext context)
        {
            try
            {
                List<Lead> tmUserMaster = context.Leads.ToList();
              
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LeadJournal>> CRMLeadJournals([Service] crmContext context)
        {
            try
            {
                List<LeadJournal> tmUserMaster = context.LeadJournals.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<LeadsLog>> CRMLeadsLogs([Service] crmContext context)
        {
            try
            {
                List<LeadsLog> tmUserMaster = context.LeadsLogs.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Leadslog1>> CRMLeadslogs1([Service] crmContext context)
        {
            try
            {
                List<Leadslog1> tmUserMaster = context.Leadslogs1.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<MigrationHistory>> CRMMigrationHistories([Service] crmContext context)
        {
            try
            {
                List<MigrationHistory> tmUserMaster = context.MigrationHistories.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Order>> CRMOrders([Service] crmContext context)
        {
            try
            {
                List<Order> tmUserMaster = context.Orders.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<OrderStatus>> CRMOrderStatuses([Service] crmContext context)
        {
            try
            {
                List<OrderStatus> tmUserMaster = context.OrderStatuses.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Product>> CRMProducts([Service] crmContext context)
        {
            try
            {
                List<Product> tmUserMaster = context.Products.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ProductCategory>> CRMProductCategories([Service] crmContext context)
        {
            try
            {
                List<ProductCategory> tmUserMaster = context.ProductCategories.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ProjectPhase>> CRMProjectPhases([Service] crmContext context)
        {
            try
            {
                List<ProjectPhase> tmUserMaster = context.ProjectPhases.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<ProjectPhaseLog>> CRMProjectPhaseLogs([Service] crmContext context)
        {
            try
            {
                List<ProjectPhaseLog> tmUserMaster = context.ProjectPhaseLogs.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Ramaster>> CRMRamasters([Service] crmContext context)
        {
            try
            {
                List<Ramaster> tmUserMaster = context.Ramasters.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<State>> CRMStates([Service] crmContext context)
        {
            try
            {
                List<State> tmUserMaster = context.States.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Status>> CRMStatuses([Service] crmContext context)
        {
            try
            {
                List<Status> tmUserMaster = context.Statuses.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<Supplier>> CRMSuppliers([Service] crmContext context)
        {
            try
            {
                List<Supplier> tmUserMaster = context.Suppliers.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [UseFiltering]
        [UseSorting]
        public Task<IQueryable<User>> CRMUsers([Service] crmContext context)
        {
            try
            {
                List<User> tmUserMaster = context.Users.ToList();
                return Task.Run(() => tmUserMaster.AsQueryable());
            }
            catch (Exception ex)
            {
                return null;
            }
        }





    }
}
