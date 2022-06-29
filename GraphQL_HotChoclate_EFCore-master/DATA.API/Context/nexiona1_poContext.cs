using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace GraphQl.DATA.API.PO.Model
{
    public partial class poContext : DbContext
    {
        public poContext()
        {
        }

        public poContext(DbContextOptions<poContext> options)
            : base(options)
        {
        }


       
        public virtual DbSet<Automumber> Automumbers { get; set; }
        public virtual DbSet<Automumber1> Automumbers1 { get; set; }
        public virtual DbSet<ChartstempTable> ChartstempTables { get; set; }
        public virtual DbSet<ChartstempTable1> ChartstempTables1 { get; set; }
        public virtual DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        public virtual DbSet<ExpenseHead> ExpenseHeads { get; set; }
        public virtual DbSet<ExpenseItem> ExpenseItems { get; set; }
        public virtual DbSet<ExpenseItemAttachment> ExpenseItemAttachments { get; set; }
        public virtual DbSet<ExpenseItemAttachment1> ExpenseItemAttachment1s { get; set; }
        public virtual DbSet<ExpenseItemAttachment2> ExpenseItemAttachments1 { get; set; }
        public virtual DbSet<ExpenseStatusMaster> ExpenseStatusMasters { get; set; }
        public virtual DbSet<ExpenseStatusState> ExpenseStatusStates { get; set; }
        public virtual DbSet<ExpenseType> ExpenseTypes { get; set; }
        public virtual DbSet<LempColorMaster> LempColorMasters { get; set; }
        public virtual DbSet<LempLeaveEmp> LempLeaveEmps { get; set; }
        public virtual DbSet<LempLeaveSetting> LempLeaveSettings { get; set; }
        public virtual DbSet<LempLeavemaster> LempLeavemasters { get; set; }
        public virtual DbSet<LempStatusmaster> LempStatusmasters { get; set; }
        public virtual DbSet<LocalExpenseHead> LocalExpenseHeads { get; set; }
        public virtual DbSet<LocalExpenseItem> LocalExpenseItems { get; set; }
        public virtual DbSet<LocalExpenseStatusState> LocalExpenseStatusStates { get; set; }
        public virtual DbSet<NempBankDetail> NempBankDetails { get; set; }
        public virtual DbSet<NempBankDetail1> NempBankDetails1 { get; set; }
        public virtual DbSet<NempDocumentUplode> NempDocumentUplodes { get; set; }
        public virtual DbSet<NempDocumentUplode1> NempDocumentUplodes1 { get; set; }
        public virtual DbSet<NempEmrcontacttwo> NempEmrcontacttwos { get; set; }
        public virtual DbSet<NempEmrcontacttwo1> NempEmrcontacttwos1 { get; set; }
        public virtual DbSet<NempEmrdetail> NempEmrdetails { get; set; }
        public virtual DbSet<NempEmrdetail1> NempEmrdetails1 { get; set; }
        public virtual DbSet<NempPersonalDetail> NempPersonalDetails { get; set; }
        public virtual DbSet<NempPersonalDetail1> NempPersonalDetails1 { get; set; }
        public virtual DbSet<TblFile> TblFiles { get; set; }
        public virtual DbSet<TmAdminModuleMaster> TmAdminModuleMasters { get; set; }
        public virtual DbSet<TmAdminSubModuleMaster> TmAdminSubModuleMasters { get; set; }
        public virtual DbSet<TmAdminUserRightsMaster> TmAdminUserRightsMasters { get; set; }
        public virtual DbSet<TmCityMaster> TmCityMasters { get; set; }
        public virtual DbSet<TmCompanyMaster> TmCompanyMasters { get; set; }
        public virtual DbSet<TmCountryMaster> TmCountryMasters { get; set; }
        public virtual DbSet<TmDashboard> TmDashboards { get; set; }
        public virtual DbSet<TmDashboard1> TmDashboards1 { get; set; }
        public virtual DbSet<TmFinaicalYear> TmFinaicalYears { get; set; }
        public virtual DbSet<TmGroupMaster> TmGroupMasters { get; set; }
        public virtual DbSet<TmPurchaseBody> TmPurchaseBodies { get; set; }
        public virtual DbSet<TmPurchaseHead> TmPurchaseHeads { get; set; }
        public virtual DbSet<TmPurchaseHead2> TmPurchaseHeads2 { get; set; }
        public virtual DbSet<TmStateMaster> TmStateMasters { get; set; }
        public virtual DbSet<TmSupplierMaster> TmSupplierMasters { get; set; }
        public virtual DbSet<TmUserMaster> TmUserMasters { get; set; }
        public virtual DbSet<TransportType> TransportTypes { get; set; }
        public virtual DbSet<TransporttypeVsRate> TransporttypeVsRates { get; set; }
        public virtual DbSet<TransporttypeVsRate1> TransporttypeVsRates1 { get; set; }
        public virtual DbSet<VwDashBoard> VwDashBoards { get; set; }
        public virtual DbSet<VwDashBoard1> VwDashBoards1 { get; set; }
        public virtual DbSet<VwLocalDashBoardDatum> VwLocalDashBoardData { get; set; }
        public virtual DbSet<VwLocalDashBoardDatum1> VwLocalDashBoardData1 { get; set; }
        public virtual DbSet<VwLocalExpense> VwLocalExpenses { get; set; }
        public virtual DbSet<VwLocalExpense1> VwLocalExpenses1 { get; set; }
        public virtual DbSet<VwLocalExpenseComment> VwLocalExpenseComments { get; set; }
        public virtual DbSet<VwLocalExpenseComment1> VwLocalExpenseComments1 { get; set; }
        public virtual DbSet<VwOutStationDashBoardDatum> VwOutStationDashBoardData { get; set; }
        public virtual DbSet<VwOutStationDashBoardDatum1> VwOutStationDashBoardData1 { get; set; }
        public virtual DbSet<VwOutStationExpense> VwOutStationExpenses { get; set; }
        public virtual DbSet<VwOutStationExpense1> VwOutStationExpenses1 { get; set; }
        public virtual DbSet<VwOutstationExpenseComment> VwOutstationExpenseComments { get; set; }
        public virtual DbSet<VwOutstationExpenseComment1> VwOutstationExpenseComments1 { get; set; }


        public virtual DbSet<CMAdminSubModuleMaster> CMAdminSubModuleMasters { get; set; }
        public virtual DbSet<CMWebUserRightsMaster> CMWebUserRightsMasters { get; set; }
        public virtual DbSet<CMAdminModuleMaster> CMAdminModuleMasters { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=nexiona1_po;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");


            //--------------------------------CUSTOM MODELS ---CMWebUserRightsMaster
            modelBuilder.Entity<CMAdminModuleMaster>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("CM_AdminModuleMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");
            });

            modelBuilder.Entity<CMAdminSubModuleMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("CM_AdminSubModuleMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.NavigationUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModule_Id");

                entity.Property(e => e.SubModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<CMWebUserRightsMaster>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("CM_Web_UserRightsMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModule_Id");

                entity.Property(e => e.UserCode).HasColumnName("User_Code");
            });




            //---------------------------------END---------------------




            modelBuilder.Entity<Automumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("automumber");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");
            });

            modelBuilder.Entity<Automumber1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("automumber", "nexionau_crm");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");
            });

            modelBuilder.Entity<ChartstempTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChartstempTable");

                entity.Property(e => e.Year)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChartstempTable1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ChartstempTable", "nexionau_crm");

                entity.Property(e => e.Year)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseGroup>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("ExpenseGroup");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.EgroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("EGroupId");

                entity.Property(e => e.EgroupName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("EGroupName");

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ExpenseHead>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("ExpenseHead");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodForm).HasColumnType("date");

                entity.Property(e => e.PeriodTo).HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkOrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseItem>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.Amt).HasColumnName("AMt");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("Date ");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseItemsId).ValueGeneratedOnAdd();

                entity.Property(e => e.PaidBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ExpenseItemAttachment>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("ExpenseItemAttachment");

                entity.Property(e => e.AttchmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                //entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.ImagDescription)
                    .HasMaxLength(356)
                    .HasColumnName("imagDescription");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseItemAttachment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExpenseItemAttachment1");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.ExpenseItemsId).ValueGeneratedOnAdd();

                entity.Property(e => e.ImagDescription)
                    .HasMaxLength(356)
                    .HasColumnName("imagDescription");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseItemAttachment2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ExpenseItemAttachment", "nexionau_crm");

                entity.Property(e => e.AttchmentId).ValueGeneratedOnAdd();

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.ImagDescription)
                    .HasMaxLength(356)
                    .HasColumnName("imagDescription");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExpenseStatusMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("ExpenseStatusMaster");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ExpenseStatusState>(entity =>
            {
               // entity.HasNoKey();

                entity.ToTable("ExpenseStatusState");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<ExpenseType>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.EgroupId).HasColumnName("EGroupId");

                entity.Property(e => e.ExpenseTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.TypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<LempColorMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEmp_colorMaster");

                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_code");
            });

            modelBuilder.Entity<LempLeaveEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEmp_LeaveEmp");

                entity.Property(e => e.ApprovelId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Approvel_Id");

                entity.Property(e => e.ApprovelStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Approvel_status");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("createdBy");

                entity.Property(e => e.CreatedTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("createdTo");

                entity.Property(e => e.Days)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DAYs");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_date");

                entity.Property(e => e.LeaveReasion)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Leave_reasion");

                entity.Property(e => e.LeaveTypes)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Leave_types");

                entity.Property(e => e.Leid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("leid");

                entity.Property(e => e.NumberOfDay)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Number_of_day");

                entity.Property(e => e.RemainingOfDay)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Remaining_of_day");

                entity.Property(e => e.StatusUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status_user");

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_date");
            });

            modelBuilder.Entity<LempLeaveSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEmp_leave_setting");

                entity.Property(e => e.AnnualLeave)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Annual_leave");

                entity.Property(e => e.CarryForward)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("carry_forward");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_on");

                entity.Property(e => e.LsetId).HasColumnName("lset_id");
            });

            modelBuilder.Entity<LempLeavemaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEmp_Leavemaster");

                entity.Property(e => e.Color)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("color");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_on");

                entity.Property(e => e.LeaveType)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("leave_type");

                entity.Property(e => e.LmId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("lm_id");
            });

            modelBuilder.Entity<LempStatusmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LEmp_Statusmaster");

                entity.Property(e => e.Comment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("comment");

                entity.Property(e => e.CreatedBy)
                    .HasColumnType("datetime")
                    .HasColumnName("created_by");

                entity.Property(e => e.CreatedOn)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("created_on");

                entity.Property(e => e.LmId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lm_id");

                entity.Property(e => e.SId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("s_id");

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("status");
            });

            modelBuilder.Entity<LocalExpenseHead>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Local_ExpenseHead");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.PeriodForm).HasColumnType("date");

                entity.Property(e => e.PeriodTo).HasColumnType("date");

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LocalExpenseItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Local_ExpenseItems");

                entity.Property(e => e.Amt).HasColumnName("AMt");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseItemsId).ValueGeneratedOnAdd();

                entity.Property(e => e.FromLocation)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ToLocation)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<LocalExpenseStatusState>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Local_ExpenseStatusState");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<NempBankDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_BankDetail");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BdId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("BD_id");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Branch_address");

                entity.Property(e => e.Createdby)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IFsc_code");

                entity.Property(e => e.PdId).HasColumnName("PD_id");
            });

            modelBuilder.Entity<NempBankDetail1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_BankDetail", "nexionau_crm");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BdId).HasColumnName("BD_id");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Branch_address");

                entity.Property(e => e.Createdby)
                    .HasColumnType("datetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("IFsc_code");

                entity.Property(e => e.PdId).HasColumnName("PD_id");
            });

            modelBuilder.Entity<NempDocumentUplode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_DocumentUplode");

                entity.Property(e => e.AddharCard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Addhar_card");

                entity.Property(e => e.Createdby)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.DuId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DU_id");

                entity.Property(e => e.EducationProof)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("education_proof");

                entity.Property(e => e.ExperienceLetter)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("experience_letter");

                entity.Property(e => e.NocLetter)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("noc_letter");

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Voterid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("voterid");
            });

            modelBuilder.Entity<NempDocumentUplode1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_DocumentUplode", "nexionau_crm");

                entity.Property(e => e.AddharCard)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Addhar_card");

                entity.Property(e => e.Createdby)
                    .HasColumnType("datetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.DuId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DU_id");

                entity.Property(e => e.EducationProof)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("education_proof");

                entity.Property(e => e.ExperienceLetter)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("experience_letter");

                entity.Property(e => e.NocLetter)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("noc_letter");

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Photo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("photo");

                entity.Property(e => e.Voterid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("voterid");
            });

            modelBuilder.Entity<NempEmrcontacttwo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_Emrcontacttwo");

                entity.Property(e => e.Createdby)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.EcId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Ec_id");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Medicalcondition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalconditionDrop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Medicalcondition_drop");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Personalmobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NempEmrcontacttwo1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_Emrcontacttwo", "nexionau_crm");

                entity.Property(e => e.Createdby)
                    .HasColumnType("datetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.EcId).HasColumnName("Ec_id");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Medicalcondition)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalconditionDrop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Medicalcondition_drop");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Personalmobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NempEmrdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_Emrdetail");

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Contact_address");

                entity.Property(e => e.Createdby)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.EdId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ED_id");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Personalmobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Post_code");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NempEmrdetail1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_Emrdetail", "nexionau_crm");

                entity.Property(e => e.ContactAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Contact_address");

                entity.Property(e => e.Createdby)
                    .HasColumnType("datetime")
                    .HasColumnName("createdby");

                entity.Property(e => e.EdId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ED_id");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId).HasColumnName("PD_id");

                entity.Property(e => e.Personalmobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Post_code");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkMobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NempPersonalDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_PersonalDetail");

                entity.Property(e => e.CreatedBy).HasColumnType("smalldatetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Father_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Home_address");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PD_id");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Post_code");
            });

            modelBuilder.Entity<NempPersonalDetail1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NEmp_PersonalDetail", "nexionau_crm");

                entity.Property(e => e.CreatedBy).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.FatherName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Father_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HomeAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("Home_address");

                entity.Property(e => e.HomeTel)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Home_tel");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PdId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PD_id");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Post_code");
            });

            modelBuilder.Entity<TblFile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblFiles");

                entity.Property(e => e.ContentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DExpenseId).HasColumnName("dExpenseID");

                entity.Property(e => e.Data).IsRequired();

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.ImagDescription)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("imagDescription");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmAdminModuleMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tm_AdminModuleMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");
            });

            modelBuilder.Entity<TmAdminSubModuleMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tm_AdminSubModuleMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.NavigationUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModule_Id");

                entity.Property(e => e.SubModuleName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmAdminUserRightsMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TM_Admin_UserRightsMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.ModuleId).HasColumnName("Module_Id");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.SubModuleId).HasColumnName("SubModule_Id");

                entity.Property(e => e.UserCode).HasColumnName("User_Code");
            });

            modelBuilder.Entity<TmCityMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_CityMaster");

                entity.Property(e => e.Citycode).HasColumnName("CITYCODE");

                entity.Property(e => e.Cityname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CITYNAME");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Deleted)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Editable)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.Statecode).HasColumnName("STATECODE");

                entity.Property(e => e.Usercode).HasColumnName("USERCODE");
            });

            modelBuilder.Entity<TmCompanyMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_CompanyMaster");

                entity.Property(e => e.Caddress1)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CAddress1");

                entity.Property(e => e.Caddress2)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CAddress2");

                entity.Property(e => e.Caddress3)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CAddress3");

                entity.Property(e => e.CemailId)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CEmailID");

                entity.Property(e => e.CmobileNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CMobileNo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cphoto)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CPhoto");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.Cwebsite)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CWebsite");

                entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DuserCode).HasColumnName("DUserCode");

                entity.Property(e => e.Iaddress1)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("IAddress1");

                entity.Property(e => e.Iaddress2)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("IAddress2");

                entity.Property(e => e.Iaddress3)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("IAddress3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Igst)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IGST");

                entity.Property(e => e.ImobileNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("IMobileNo");

                entity.Property(e => e.Iname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("IName");

                entity.Property(e => e.IpanNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("IPanNo");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.ReasonForDeletion)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Saddress1)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SAddress1");

                entity.Property(e => e.Saddress2)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SAddress2");

                entity.Property(e => e.Saddress3)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SAddress3");

                entity.Property(e => e.SattendentName)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SAttendentName");

                entity.Property(e => e.SmobileNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SMobileNo");

                entity.Property(e => e.Sname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("SName");

                entity.Property(e => e.SpanNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("SPanNo");
            });

            modelBuilder.Entity<TmCountryMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_CountryMaster");

                entity.Property(e => e.Countrycode).HasColumnName("COUNTRYCODE");

                entity.Property(e => e.Countryname)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRYNAME");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Deleted)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Editable)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.Usercode).HasColumnName("USERCODE");
            });

            modelBuilder.Entity<TmDashboard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tm_Dashboard");

                entity.Property(e => e.ToTalPo).HasColumnName("ToTalPO");
            });

            modelBuilder.Entity<TmDashboard1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tm_Dashboard", "nexionau_crm");

                entity.Property(e => e.ToTalPo).HasColumnName("ToTalPO");
            });

            modelBuilder.Entity<TmFinaicalYear>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_FinaicalYear");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.Enddate).HasColumnType("date");

                entity.Property(e => e.Expenseid).HasColumnName("EXPENSEid");

                entity.Property(e => e.Fyname)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("FYname");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<TmGroupMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("Tm_GroupMaster");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Group_Name");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.Rid).HasColumnName("RID");
            });

            modelBuilder.Entity<TmPurchaseBody>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_PurchaseBody");

                entity.Property(e => e.Catname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("catname");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Dis).HasColumnName("DIS");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.PoId).HasColumnName("PO_Id");

                entity.Property(e => e.Qty).HasColumnName("QTY");

                entity.Property(e => e.Uom)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UOM");
            });

            modelBuilder.Entity<TmPurchaseHead>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_PurchaseHead");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.DeliveryMode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Enduser)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.FreightTerms)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndentNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.PoId).HasColumnName("PO_Id");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmPurchaseHead2>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("vv_PurchaseHead2");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.DeliveryMode)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Enduser)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.FreightTerms)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Gst)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IndentNo)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.Property(e => e.PaymentTerms)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.PoId).HasColumnName("PO_Id");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.WorkOrderNo)
                    .HasMaxLength(350)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmStateMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("TM_StateMaster");

                entity.Property(e => e.Countrycode).HasColumnName("COUNTRYCODE");

                entity.Property(e => e.Creationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATIONDATE");

                entity.Property(e => e.Deleted)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayAs)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Editable)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Modificationdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MODIFICATIONDATE");

                entity.Property(e => e.Statecode).HasColumnName("STATECODE");

                entity.Property(e => e.Statename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STATENAME");

                entity.Property(e => e.Usercode).HasColumnName("USERCODE");
            });

            modelBuilder.Entity<TmSupplierMaster>(entity =>
            {
                //entity.HasNoKey();

                entity.ToTable("Tm_supplierMaster");

                entity.Property(e => e.Address1)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.CmobileNo)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("CMobileNo");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.Gst)
                    .HasMaxLength(350)
                    .IsUnicode(false)
                    .HasColumnName("GST");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.RecordStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmUserMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TM_UserMaster");

                entity.Property(e => e.AccountStatus)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Creation_Date");

                entity.Property(e => e.CuserId).HasColumnName("CUser_Id");

                entity.Property(e => e.DeletedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DuserCode).HasColumnName("DUserCode");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EmailID");

                entity.Property(e => e.FromTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FromTimeAmPm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FromTime_AM_PM");

                entity.Property(e => e.GroupId).HasColumnName("Group_Id");

                entity.Property(e => e.LastLoginDateTime)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("lastLoginDateTime");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Modification_Date");

                entity.Property(e => e.MuserId).HasColumnName("MUser_Id");

                entity.Property(e => e.ReasonForDeletion)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Recordstatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RID");

                entity.Property(e => e.ToTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ToTimeAmPm)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ToTime_AM_PM");

                entity.Property(e => e.Upassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("UPassword");

                entity.Property(e => e.UserCode).HasColumnName("User_Code");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.UserImage)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransportType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.TransportTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.TypeName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TransporttypeVsRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransporttypeVsRate");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Rid).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TransporttypeVsRate1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransporttypeVsRate", "nexionau_crm");

                entity.Property(e => e.CreatedOn).HasColumnType("datetime");

                entity.Property(e => e.Rid).ValueGeneratedOnAdd();

                entity.Property(e => e.UpdateOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwDashBoard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DashBoard");
            });

            modelBuilder.Entity<VwDashBoard1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_DashBoard", "nexionau_crm");
            });

            modelBuilder.Entity<VwLocalDashBoardDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LocalDashBoardData");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VwLocalDashBoardDatum1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LocalDashBoardData", "nexionau_crm");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VwLocalExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LocalExpense");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.PeriodForm)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodTo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("statusname");

                entity.Property(e => e.UpdatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLocalExpense1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_LocalExpense", "nexionau_crm");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.PeriodForm)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodTo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("statusname");

                entity.Property(e => e.UpdatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLocalExpenseComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_LocalExpenseComments");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLocalExpenseComment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_LocalExpenseComments", "nexionau_crm");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOutStationDashBoardDatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OutStationDashBoardData");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VwOutStationDashBoardDatum1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OutStationDashBoardData", "nexionau_crm");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<VwOutStationExpense>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OutStationExpense");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodForm)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodTo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("statusname");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOutStationExpense1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_OutStationExpense", "nexionau_crm");

                entity.Property(e => e.CreatedBy).HasColumnName("createdBy");

                entity.Property(e => e.CreatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodForm)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodTo)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Statusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("statusname");

                entity.Property(e => e.Title)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.WorkOrderId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOutstationExpenseComment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_outstationExpenseComments");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwOutstationExpenseComment1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Vw_outstationExpenseComments", "nexionau_crm");

                entity.Property(e => e.Comments)
                    .HasMaxLength(356)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedOn).HasColumnType("smalldatetime");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
