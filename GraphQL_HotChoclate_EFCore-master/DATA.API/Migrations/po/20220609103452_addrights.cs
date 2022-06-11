using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GraphQl.DATA.API.Migrations.po
{
    public partial class addrights : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "nexionau_crm");

            migrationBuilder.CreateTable(
                name: "automumber",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "automumber",
                schema: "nexionau_crm",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChartstempTable",
                columns: table => new
                {
                    Year = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Submit = table.Column<double>(type: "float", nullable: true),
                    Approved = table.Column<double>(type: "float", nullable: true),
                    Complate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ChartstempTable",
                schema: "nexionau_crm",
                columns: table => new
                {
                    Year = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Submit = table.Column<double>(type: "float", nullable: true),
                    Approved = table.Column<double>(type: "float", nullable: true),
                    Complate = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CM_AdminModuleMaster",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    ModuleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ModuleOrder = table.Column<int>(type: "int", nullable: false),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CUser_Id = table.Column<int>(type: "int", nullable: false),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MUser_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_AdminModuleMaster", x => x.RID);
                });

            migrationBuilder.CreateTable(
                name: "CM_AdminSubModuleMaster",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    SubModule_Id = table.Column<int>(type: "int", nullable: false),
                    SubModuleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CUser_Id = table.Column<int>(type: "int", nullable: false),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MUser_Id = table.Column<int>(type: "int", nullable: false),
                    SubModuleOrder = table.Column<int>(type: "int", nullable: false),
                    NavigationUrl = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TargetModule = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_AdminSubModuleMaster", x => x.RID);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseGroup",
                columns: table => new
                {
                    EGroupName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    EGroupId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseHead",
                columns: table => new
                {
                    ExpenseId = table.Column<long>(type: "bigint", nullable: false),
                    Title = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    PeriodForm = table.Column<DateTime>(type: "date", nullable: true),
                    PeriodTo = table.Column<DateTime>(type: "date", nullable: true),
                    WorkOrderId = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Location = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItemAttachment",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    imagDescription = table.Column<string>(type: "nvarchar(356)", maxLength: 356, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    AttchmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItemAttachment",
                schema: "nexionau_crm",
                columns: table => new
                {
                    AttchmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpenseID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    imagDescription = table.Column<string>(type: "nvarchar(356)", maxLength: 356, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItemAttachment1",
                columns: table => new
                {
                    ExpenseID = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    imagDescription = table.Column<string>(type: "nvarchar(356)", maxLength: 356, nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ExpenseItemsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseItems",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(name: "Date ", type: "date", nullable: true),
                    ExpenseTypeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    ApprovedAmount = table.Column<double>(type: "float", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    PaidBy = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Distance = table.Column<double>(type: "float", nullable: true),
                    ParkingAmt = table.Column<double>(type: "float", nullable: true),
                    AMt = table.Column<double>(type: "float", nullable: true),
                    ExpenseItemsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseStatusMaster",
                columns: table => new
                {
                    StatusName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseStatusState",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "varchar(356)", unicode: false, maxLength: 356, nullable: true),
                    RID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExpenseTypes",
                columns: table => new
                {
                    ExpenseTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    EGroupId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    Amt = table.Column<bool>(type: "bit", nullable: true),
                    Km = table.Column<bool>(type: "bit", nullable: true),
                    Park = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LEmp_colorMaster",
                columns: table => new
                {
                    user_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    color = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LEmp_leave_setting",
                columns: table => new
                {
                    lset_id = table.Column<int>(type: "int", nullable: false),
                    Annual_leave = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    carry_forward = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_by = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LEmp_LeaveEmp",
                columns: table => new
                {
                    leid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Leave_types = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    From_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    To_date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Number_of_day = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Remaining_of_day = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Leave_reasion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    createdBy = table.Column<DateTime>(type: "datetime", nullable: true),
                    createdTo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Approvel_status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Approvel_Id = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    status_user = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DAYs = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LEmp_Leavemaster",
                columns: table => new
                {
                    lm_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    leave_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_by = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Alloted = table.Column<int>(type: "int", nullable: true),
                    color = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LEmp_Statusmaster",
                columns: table => new
                {
                    s_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    comment = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    lm_id = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    created_by = table.Column<DateTime>(type: "datetime", nullable: true),
                    created_on = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Local_ExpenseHead",
                columns: table => new
                {
                    ExpenseId = table.Column<long>(type: "bigint", nullable: false),
                    PeriodForm = table.Column<DateTime>(type: "date", nullable: true),
                    PeriodTo = table.Column<DateTime>(type: "date", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Local_ExpenseItems",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    FromLocation = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    ToLocation = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    Purpose = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    TransportTypeId = table.Column<int>(type: "int", nullable: true),
                    Distance = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: true),
                    ApprovedAmount = table.Column<double>(type: "float", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    ParkingAmt = table.Column<double>(type: "float", nullable: true),
                    AMt = table.Column<double>(type: "float", nullable: true),
                    ExpenseItemsId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Local_ExpenseStatusState",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(type: "int", nullable: true),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "varchar(356)", unicode: false, maxLength: 356, nullable: true),
                    RID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_BankDetail",
                columns: table => new
                {
                    BankName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IFsc_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Branch_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true),
                    BD_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_BankDetail",
                schema: "nexionau_crm",
                columns: table => new
                {
                    BD_id = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AccountNumber = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    IFsc_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Branch_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "datetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_DocumentUplode",
                columns: table => new
                {
                    photo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Addhar_card = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    voterid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    education_proof = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    experience_letter = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    noc_letter = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true),
                    DU_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_DocumentUplode",
                schema: "nexionau_crm",
                columns: table => new
                {
                    DU_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Addhar_card = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    voterid = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    education_proof = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    experience_letter = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    noc_letter = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "datetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_Emrcontacttwo",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WorkMobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Personalmobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Medicalcondition_drop = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Medicalcondition = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true),
                    Ec_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_Emrcontacttwo",
                schema: "nexionau_crm",
                columns: table => new
                {
                    Ec_id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WorkMobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Personalmobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Medicalcondition_drop = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Medicalcondition = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    createdby = table.Column<DateTime>(type: "datetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_Emrdetail",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Contact_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Post_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WorkMobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Personalmobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    createdby = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true),
                    ED_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_Emrdetail",
                schema: "nexionau_crm",
                columns: table => new
                {
                    ED_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Relationship = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Contact_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Post_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    WorkMobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Personalmobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    createdby = table.Column<DateTime>(type: "datetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_PersonalDetail",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Father_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mother_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Post_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedBy = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    PD_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NEmp_PersonalDetail",
                schema: "nexionau_crm",
                columns: table => new
                {
                    PD_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DOB = table.Column<DateTime>(type: "date", nullable: true),
                    Gender = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Father_name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mother_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_address = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Post_code = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Home_tel = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CreatedBy = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "tblFiles",
                columns: table => new
                {
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    imagDescription = table.Column<string>(type: "varchar(256)", unicode: false, maxLength: 256, nullable: true),
                    dExpenseID = table.Column<int>(type: "int", nullable: true),
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_Admin_UserRightsMaster",
                columns: table => new
                {
                    Group_Id = table.Column<int>(type: "int", nullable: false),
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    SubModule_Id = table.Column<int>(type: "int", nullable: false),
                    CanView = table.Column<bool>(type: "bit", nullable: false),
                    CanSave = table.Column<bool>(type: "bit", nullable: false),
                    CanSearch = table.Column<bool>(type: "bit", nullable: false),
                    CanUpdate = table.Column<bool>(type: "bit", nullable: false),
                    CanDelete = table.Column<bool>(type: "bit", nullable: false),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CUser_Id = table.Column<int>(type: "int", nullable: false),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MUser_Id = table.Column<int>(type: "int", nullable: false),
                    User_Code = table.Column<int>(type: "int", nullable: false),
                    CanExport = table.Column<bool>(type: "bit", nullable: false),
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_AdminModuleMaster",
                columns: table => new
                {
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    ModuleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ModuleOrder = table.Column<int>(type: "int", nullable: false),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CUser_Id = table.Column<int>(type: "int", nullable: false),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MUser_Id = table.Column<int>(type: "int", nullable: false),
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_AdminSubModuleMaster",
                columns: table => new
                {
                    Module_Id = table.Column<int>(type: "int", nullable: false),
                    SubModule_Id = table.Column<int>(type: "int", nullable: false),
                    SubModuleName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    CUser_Id = table.Column<int>(type: "int", nullable: false),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MUser_Id = table.Column<int>(type: "int", nullable: false),
                    SubModuleOrder = table.Column<int>(type: "int", nullable: false),
                    NavigationUrl = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_CityMaster",
                columns: table => new
                {
                    CITYCODE = table.Column<int>(type: "int", nullable: false),
                    CITYNAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    STATECODE = table.Column<int>(type: "int", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    USERCODE = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Editable = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_CompanyMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    CompanyName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    CAddress1 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CAddress2 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CAddress3 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CEmailID = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CMobileNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CWebsite = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CPhoto = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IAddress1 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IAddress2 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IAddress3 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IGST = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    IMobileNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IPanNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    SAddress1 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SAddress2 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SAddress3 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SAttendentName = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SMobileNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    SPanNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true),
                    Recordstatus = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ReasonForDeletion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    DUserCode = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_CountryMaster",
                columns: table => new
                {
                    COUNTRYCODE = table.Column<int>(type: "int", nullable: false),
                    COUNTRYNAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DisplayAs = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    USERCODE = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Editable = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_Dashboard",
                columns: table => new
                {
                    ToTalPO = table.Column<int>(type: "int", nullable: true),
                    TotalPoToday = table.Column<int>(type: "int", nullable: true),
                    TotalPoAmount = table.Column<double>(type: "float", nullable: false),
                    TotalPoTodayAmount = table.Column<double>(type: "float", nullable: false),
                    TotalUsers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_Dashboard",
                schema: "nexionau_crm",
                columns: table => new
                {
                    ToTalPO = table.Column<int>(type: "int", nullable: true),
                    TotalPoToday = table.Column<int>(type: "int", nullable: true),
                    TotalPoAmount = table.Column<double>(type: "float", nullable: false),
                    TotalPoTodayAmount = table.Column<double>(type: "float", nullable: false),
                    TotalUsers = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_FinaicalYear",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: true),
                    FYname = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    StartDate = table.Column<DateTime>(type: "date", nullable: true),
                    Enddate = table.Column<DateTime>(type: "date", nullable: true),
                    PoNumber = table.Column<int>(type: "int", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true),
                    EXPENSEid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_GroupMaster",
                columns: table => new
                {
                    RID = table.Column<int>(type: "int", nullable: false),
                    Group_Id = table.Column<int>(type: "int", nullable: false),
                    Group_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_PurchaseBody",
                columns: table => new
                {
                    PO_Id = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    UOM = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    QTY = table.Column<int>(type: "int", nullable: true),
                    ListPrice = table.Column<double>(type: "float", nullable: true),
                    DIS = table.Column<double>(type: "float", nullable: true),
                    UnitPrice = table.Column<double>(type: "float", nullable: true),
                    NetPrice = table.Column<double>(type: "float", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true),
                    ID = table.Column<decimal>(type: "numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    catname = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_PurchaseHead",
                columns: table => new
                {
                    PO_Id = table.Column<int>(type: "int", nullable: true),
                    CompanyID = table.Column<int>(type: "int", nullable: true),
                    SupplierID = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "date", nullable: true),
                    PaymentTerms = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    IndentNo = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    FreightTerms = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    WorkOrderNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Gst = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "date", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Total = table.Column<double>(type: "float", nullable: true),
                    Enduser = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true),
                    DeliveryMode = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_StateMaster",
                columns: table => new
                {
                    STATECODE = table.Column<int>(type: "int", nullable: false),
                    STATENAME = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    DisplayAs = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    COUNTRYCODE = table.Column<int>(type: "int", nullable: false),
                    CREATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MODIFICATIONDATE = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    USERCODE = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true),
                    Editable = table.Column<string>(type: "varchar(3)", unicode: false, maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tm_supplierMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: true),
                    SupplierName = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Address1 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Address2 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    Address3 = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    ContactPerson = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    CMobileNo = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    GST = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    RecordStatus = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TM_UserMaster",
                columns: table => new
                {
                    UserName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    UserID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UPassword = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    EmailID = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MobileNo = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    Group_Id = table.Column<int>(type: "int", nullable: true),
                    AccountStatus = table.Column<string>(type: "varchar(12)", unicode: false, maxLength: 12, nullable: true),
                    FromTime = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    FromTime_AM_PM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ToTime = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ToTime_AM_PM = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    UserImage = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CUser_Id = table.Column<int>(type: "int", nullable: true),
                    Modification_Date = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    MUser_Id = table.Column<int>(type: "int", nullable: true),
                    Recordstatus = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ReasonForDeletion = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    DUserCode = table.Column<int>(type: "int", nullable: true),
                    User_Code = table.Column<int>(type: "int", nullable: true),
                    lastLoginDateTime = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ReportingManager = table.Column<int>(type: "int", nullable: true),
                    RID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TransportTypes",
                columns: table => new
                {
                    TypeName = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    TransportTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TransporttypeVsRate",
                columns: table => new
                {
                    TransportTypeId = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true),
                    Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "TransporttypeVsRate",
                schema: "nexionau_crm",
                columns: table => new
                {
                    Rid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransportTypeId = table.Column<int>(type: "int", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdateOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdateBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "automumber");

            migrationBuilder.DropTable(
                name: "automumber",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "ChartstempTable");

            migrationBuilder.DropTable(
                name: "ChartstempTable",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "CM_AdminModuleMaster");

            migrationBuilder.DropTable(
                name: "CM_AdminSubModuleMaster");

            migrationBuilder.DropTable(
                name: "ExpenseGroup");

            migrationBuilder.DropTable(
                name: "ExpenseHead");

            migrationBuilder.DropTable(
                name: "ExpenseItemAttachment");

            migrationBuilder.DropTable(
                name: "ExpenseItemAttachment",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "ExpenseItemAttachment1");

            migrationBuilder.DropTable(
                name: "ExpenseItems");

            migrationBuilder.DropTable(
                name: "ExpenseStatusMaster");

            migrationBuilder.DropTable(
                name: "ExpenseStatusState");

            migrationBuilder.DropTable(
                name: "ExpenseTypes");

            migrationBuilder.DropTable(
                name: "LEmp_colorMaster");

            migrationBuilder.DropTable(
                name: "LEmp_leave_setting");

            migrationBuilder.DropTable(
                name: "LEmp_LeaveEmp");

            migrationBuilder.DropTable(
                name: "LEmp_Leavemaster");

            migrationBuilder.DropTable(
                name: "LEmp_Statusmaster");

            migrationBuilder.DropTable(
                name: "Local_ExpenseHead");

            migrationBuilder.DropTable(
                name: "Local_ExpenseItems");

            migrationBuilder.DropTable(
                name: "Local_ExpenseStatusState");

            migrationBuilder.DropTable(
                name: "NEmp_BankDetail");

            migrationBuilder.DropTable(
                name: "NEmp_BankDetail",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "NEmp_DocumentUplode");

            migrationBuilder.DropTable(
                name: "NEmp_DocumentUplode",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "NEmp_Emrcontacttwo");

            migrationBuilder.DropTable(
                name: "NEmp_Emrcontacttwo",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "NEmp_Emrdetail");

            migrationBuilder.DropTable(
                name: "NEmp_Emrdetail",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "NEmp_PersonalDetail");

            migrationBuilder.DropTable(
                name: "NEmp_PersonalDetail",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "tblFiles");

            migrationBuilder.DropTable(
                name: "TM_Admin_UserRightsMaster");

            migrationBuilder.DropTable(
                name: "Tm_AdminModuleMaster");

            migrationBuilder.DropTable(
                name: "Tm_AdminSubModuleMaster");

            migrationBuilder.DropTable(
                name: "TM_CityMaster");

            migrationBuilder.DropTable(
                name: "TM_CompanyMaster");

            migrationBuilder.DropTable(
                name: "TM_CountryMaster");

            migrationBuilder.DropTable(
                name: "Tm_Dashboard");

            migrationBuilder.DropTable(
                name: "Tm_Dashboard",
                schema: "nexionau_crm");

            migrationBuilder.DropTable(
                name: "TM_FinaicalYear");

            migrationBuilder.DropTable(
                name: "Tm_GroupMaster");

            migrationBuilder.DropTable(
                name: "TM_PurchaseBody");

            migrationBuilder.DropTable(
                name: "TM_PurchaseHead");

            migrationBuilder.DropTable(
                name: "TM_StateMaster");

            migrationBuilder.DropTable(
                name: "Tm_supplierMaster");

            migrationBuilder.DropTable(
                name: "TM_UserMaster");

            migrationBuilder.DropTable(
                name: "TransportTypes");

            migrationBuilder.DropTable(
                name: "TransporttypeVsRate");

            migrationBuilder.DropTable(
                name: "TransporttypeVsRate",
                schema: "nexionau_crm");
        }
    }
}
