using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_Base_GHR_GCard_GControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Storage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(21)", maxLength: 21, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCard_PasswordRemakes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_PasswordRemakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_Announcement",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_Announcement", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_ApplicationSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_ApplicationSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EmployeeLabels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EmployeeLabels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EmployeeTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EmployeeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Radius = table.Column<int>(type: "int", nullable: false),
                    EntryTimeLimit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEntryTimeLimitEnabled = table.Column<bool>(type: "bit", nullable: true),
                    LocationOut = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_PasswordRemakes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_PasswordRemakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_ShiftManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShiftStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShiftEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    Monday = table.Column<bool>(type: "bit", nullable: false),
                    Tuesday = table.Column<bool>(type: "bit", nullable: false),
                    Wednesday = table.Column<bool>(type: "bit", nullable: false),
                    Thursday = table.Column<bool>(type: "bit", nullable: false),
                    Friday = table.Column<bool>(type: "bit", nullable: false),
                    Saturday = table.Column<bool>(type: "bit", nullable: false),
                    Sunday = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_ShiftManagements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GControl_UserMainInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_UserMainInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_Appellations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainAppellationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Appellations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobApplicationStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobApplicationStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_LeaveTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_LeaveTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_Recruiters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Recruiters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_RecruitmentProcesses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_RecruitmentProcesses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GHR_SelfServices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_SelfServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_AnnouncementEmployeeLabel",
                columns: table => new
                {
                    AnnouncementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeLabelsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_AnnouncementEmployeeLabel", x => new { x.AnnouncementsId, x.EmployeeLabelsId });
                    table.ForeignKey(
                        name: "FK_GControl_AnnouncementEmployeeLabel_GControl_Announcement_AnnouncementsId",
                        column: x => x.AnnouncementsId,
                        principalTable: "GControl_Announcement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_AnnouncementEmployeeLabel_GControl_EmployeeLabels_EmployeeLabelsId",
                        column: x => x.EmployeeLabelsId,
                        principalTable: "GControl_EmployeeLabels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Salary = table.Column<float>(type: "real", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AppellationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManagedDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_Employees_GHR_Appellations_AppellationId",
                        column: x => x.AppellationId,
                        principalTable: "GHR_Appellations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobAdverts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfVacancy = table.Column<int>(type: "int", nullable: false),
                    PostingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AppellationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkLocationString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobAdverts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobAdverts_GHR_Appellations_AppellationId",
                        column: x => x.AppellationId,
                        principalTable: "GHR_Appellations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobApplicationStatusHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobApplicationStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobApplicationStatusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobApplicationStatusHistories_GHR_JobApplicationStatuses_JobApplicationStatusId",
                        column: x => x.JobApplicationStatusId,
                        principalTable: "GHR_JobApplicationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_DepartmentManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_DepartmentManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_DepartmentManagers_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_EducationInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_EducationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_EducationInfos_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_EmployeeRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_EmployeeRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_EmployeeRoles_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_Leaves",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayCount = table.Column<int>(type: "int", nullable: true),
                    HourCount = table.Column<double>(type: "float", nullable: true),
                    LeaveTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeReplacement = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LeaveStatus = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Leaves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_Leaves_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GHR_Leaves_GHR_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "GHR_LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_Payrolls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DayCount = table.Column<int>(type: "int", nullable: true),
                    SalaryPaid = table.Column<double>(type: "float", nullable: true),
                    SalaryTotal = table.Column<double>(type: "float", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Payrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_Payrolls_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobAdvertPostedOn",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobAdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostedLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobAdvertPostedOn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobAdvertPostedOn_GHR_JobAdverts_JobAdvertId",
                        column: x => x.JobAdvertId,
                        principalTable: "GHR_JobAdverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobApplicants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobAdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobApplicantDocumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobApplicants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobApplicants_AppFiles_JobApplicantDocumentId",
                        column: x => x.JobApplicantDocumentId,
                        principalTable: "AppFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GHR_JobApplicants_GHR_JobAdverts_JobAdvertId",
                        column: x => x.JobAdvertId,
                        principalTable: "GHR_JobAdverts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_Locations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobAdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_Locations_GHR_JobAdverts_JobAdvertId",
                        column: x => x.JobAdvertId,
                        principalTable: "GHR_JobAdverts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_RecruitmentSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobAdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_RecruitmentSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_RecruitmentSteps_GHR_JobAdverts_JobAdvertId",
                        column: x => x.JobAdvertId,
                        principalTable: "GHR_JobAdverts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_RoleTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeRolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_RoleTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_RoleTypes_GHR_EmployeeRoles_EmployeeRolesId",
                        column: x => x.EmployeeRolesId,
                        principalTable: "GHR_EmployeeRoles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobApplications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobApplicantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RecruitmentProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobApplicationStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobAdvertId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ApplicationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobApplications_GHR_JobAdverts_JobAdvertId",
                        column: x => x.JobAdvertId,
                        principalTable: "GHR_JobAdverts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GHR_JobApplications_GHR_JobApplicants_JobApplicantId",
                        column: x => x.JobApplicantId,
                        principalTable: "GHR_JobApplicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GHR_JobApplications_GHR_JobApplicationStatuses_JobApplicationStatusId",
                        column: x => x.JobApplicationStatusId,
                        principalTable: "GHR_JobApplicationStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GHR_JobApplications_GHR_Recruiters_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "GHR_Recruiters",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GHR_JobApplications_GHR_RecruitmentProcesses_RecruitmentProcessId",
                        column: x => x.RecruitmentProcessId,
                        principalTable: "GHR_RecruitmentProcesses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_Notes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruiterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoteText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_Notes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_Notes_GHR_JobApplicants_ApplicantId",
                        column: x => x.ApplicantId,
                        principalTable: "GHR_JobApplicants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GHR_Notes_GHR_Recruiters_RecruiterId",
                        column: x => x.RecruiterId,
                        principalTable: "GHR_Recruiters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GHR_RecruitmentProcessSteps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruitmentProcessId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RecruitmentStepId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_RecruitmentProcessSteps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_RecruitmentProcessSteps_GHR_RecruitmentProcesses_RecruitmentProcessId",
                        column: x => x.RecruitmentProcessId,
                        principalTable: "GHR_RecruitmentProcesses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GHR_RecruitmentProcessSteps_GHR_RecruitmentSteps_RecruitmentStepId",
                        column: x => x.RecruitmentStepId,
                        principalTable: "GHR_RecruitmentSteps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserAppUserFile",
                columns: table => new
                {
                    AppUserFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserAppUserFile", x => new { x.AppUserFilesId, x.AppUsersId });
                    table.ForeignKey(
                        name: "FK_AppUserAppUserFile_AppFiles_AppUserFilesId",
                        column: x => x.AppUserFilesId,
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLicenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsInUse = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLicenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProfileImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Idc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Idc);
                    table.ForeignKey(
                        name: "FK_Countries_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Idc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Idc);
                    table.ForeignKey(
                        name: "FK_Cities_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Idc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Idc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Idc);
                    table.ForeignKey(
                        name: "FK_Districts_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Districts_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Districts_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Idc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterCompanyIdFromPlatform = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MainCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LogoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TradeRegisterNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialSecurityNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Companies_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Idc");
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorizedFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Branches_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Branches_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Idc");
                });

            migrationBuilder.CreateTable(
                name: "CompanyCompanyFile",
                columns: table => new
                {
                    CompaniesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyCompanyFile", x => new { x.CompaniesId, x.CompanyFilesId });
                    table.ForeignKey(
                        name: "FK_CompanyCompanyFile_AppFiles_CompanyFilesId",
                        column: x => x.CompanyFilesId,
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyCompanyFile_Companies_CompaniesId",
                        column: x => x.CompaniesId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompanyLicenses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsInUse = table.Column<bool>(type: "bit", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyLicenses_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyLicenses_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyLicenses_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyLicenses_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CompanyLicenses_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MainDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Departments_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Departments_GHR_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GHR_Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Addresses_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_Cargos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxRate = table.Column<int>(type: "int", nullable: false),
                    CargoPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Cargos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Cargos_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_Fields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Fields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Fields_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_SocialMedias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_SocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_SocialMedias_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_Staffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Staffs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Staffs_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MailCredantials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    From = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Port = table.Column<int>(type: "int", nullable: false),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnableSsl = table.Column<bool>(type: "bit", nullable: false),
                    IsVerified = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MailCredantials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MailCredantials_AspNetUsers_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailCredantials_AspNetUsers_DeletedBy",
                        column: x => x.DeletedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailCredantials_AspNetUsers_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MailCredantials_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MailCredantials_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GControl_Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BaseDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GControl_Department_Departments_BaseDepartmentId",
                        column: x => x.BaseDepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_Department_GControl_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GControl_Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfilePicturePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartWorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GControl_Employees_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_Employees_GControl_EmployeeTypes_EmployeeTypeId",
                        column: x => x.EmployeeTypeId,
                        principalTable: "GControl_EmployeeTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_Employees_GControl_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GControl_Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GHR_JobHistories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GHR_JobHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GHR_JobHistories_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GHR_JobHistories_GHR_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GHR_Employees",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_Ibans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IbanNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Ibans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Ibans_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_Ibans_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_PhoneNumbers_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_PhoneNumbers_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_SocialMediaUrls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UrlPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocialMediaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_SocialMediaUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_SocialMediaUrls_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_SocialMediaUrls_GCard_SocialMedias_SocialMediaId",
                        column: x => x.SocialMediaId,
                        principalTable: "GCard_SocialMedias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCard_SocialMediaUrls_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_StaffContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_StaffContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_StaffContacts_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_StaffContacts_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_StaffFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FieldId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_StaffFields", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_StaffFields_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_StaffFields_GCard_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "GCard_Fields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCard_StaffFields_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_StaffStaffFile",
                columns: table => new
                {
                    StaffFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StaffsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_StaffStaffFile", x => new { x.StaffFilesId, x.StaffsId });
                    table.ForeignKey(
                        name: "FK_GCard_StaffStaffFile_AppFiles_StaffFilesId",
                        column: x => x.StaffFilesId,
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCard_StaffStaffFile_GCard_Staffs_StaffsId",
                        column: x => x.StaffsId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_AnnouncementDepartment",
                columns: table => new
                {
                    AnnouncementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_AnnouncementDepartment", x => new { x.AnnouncementsId, x.DepartmentsId });
                    table.ForeignKey(
                        name: "FK_GControl_AnnouncementDepartment_GControl_Announcement_AnnouncementsId",
                        column: x => x.AnnouncementsId,
                        principalTable: "GControl_Announcement",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_AnnouncementDepartment_GControl_Department_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "GControl_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_ApplicationSettingEmployee",
                columns: table => new
                {
                    ApplicationSettingsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_ApplicationSettingEmployee", x => new { x.ApplicationSettingsId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_GControl_ApplicationSettingEmployee_GControl_ApplicationSettings_ApplicationSettingsId",
                        column: x => x.ApplicationSettingsId,
                        principalTable: "GControl_ApplicationSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_ApplicationSettingEmployee_GControl_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "GControl_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EmployeeEmployeeFile",
                columns: table => new
                {
                    EmployeeFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EmployeeEmployeeFile", x => new { x.EmployeeFilesId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeEmployeeFile_AppFiles_EmployeeFilesId",
                        column: x => x.EmployeeFilesId,
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeEmployeeFile_GControl_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "GControl_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EmployeeEmployeeLabel",
                columns: table => new
                {
                    EmployeeLabelsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EmployeeEmployeeLabel", x => new { x.EmployeeLabelsId, x.EmployeesId });
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeEmployeeLabel_GControl_EmployeeLabels_EmployeeLabelsId",
                        column: x => x.EmployeeLabelsId,
                        principalTable: "GControl_EmployeeLabels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeEmployeeLabel_GControl_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "GControl_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EmployeeShiftManagement",
                columns: table => new
                {
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftManagementsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EmployeeShiftManagement", x => new { x.EmployeesId, x.ShiftManagementsId });
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeShiftManagement_GControl_Employees_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "GControl_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_EmployeeShiftManagement_GControl_ShiftManagements_ShiftManagementsId",
                        column: x => x.ShiftManagementsId,
                        principalTable: "GControl_ShiftManagements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GControl_EntryExitManagements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsLocationOut = table.Column<bool>(type: "bit", nullable: false),
                    IsRegistrationType = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GControl_EntryExitManagements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GControl_EntryExitManagements_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_EntryExitManagements_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GControl_EntryExitManagements_GControl_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "GControl_Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GControl_EntryExitManagements_GControl_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "GControl_Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_Cards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRate = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Cards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCard_Invoices",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Invoices_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_Invoices_GCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "GCard_Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCard_Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: true),
                    PaymentStatus = table.Column<int>(type: "int", nullable: true),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GeneralTotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GeneralTotalTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BuyerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InvoiceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_Orders_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_Orders_GCard_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "GCard_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCard_Orders_GCard_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "GCard_Invoices",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCard_OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxRate = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CardId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PurchasedForStaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StaffId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseProjectCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BaseProjectBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCard_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCard_OrderDetails_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCard_OrderDetails_GCard_Cards_CardId",
                        column: x => x.CardId,
                        principalTable: "GCard_Cards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCard_OrderDetails_GCard_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "GCard_Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GCard_OrderDetails_GCard_Staffs_PurchasedForStaffId",
                        column: x => x.PurchasedForStaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GCard_OrderDetails_GCard_Staffs_StaffId",
                        column: x => x.StaffId,
                        principalTable: "GCard_Staffs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAppUserFile_AppUsersId",
                table: "AppUserAppUserFile",
                column: "AppUsersId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserLicenses_AppUserId",
                table: "AppUserLicenses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserLicenses_CreatedBy",
                table: "AppUserLicenses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserLicenses_DeletedBy",
                table: "AppUserLicenses",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserLicenses_UpdatedBy",
                table: "AppUserLicenses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CompanyId",
                table: "Branches",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_CreatedBy",
                table: "Branches",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DeletedBy",
                table: "Branches",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_DistrictId",
                table: "Branches",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_UpdatedBy",
                table: "Branches",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CreatedBy",
                table: "Cities",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DeletedBy",
                table: "Cities",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_UpdatedBy",
                table: "Cities",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_AppUserId",
                table: "Companies",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_CreatedBy",
                table: "Companies",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DeletedBy",
                table: "Companies",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DistrictId",
                table: "Companies",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_UpdatedBy",
                table: "Companies",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyCompanyFile_CompanyFilesId",
                table: "CompanyCompanyFile",
                column: "CompanyFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLicenses_AppUserId",
                table: "CompanyLicenses",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLicenses_CompanyId",
                table: "CompanyLicenses",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLicenses_CreatedBy",
                table: "CompanyLicenses",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLicenses_DeletedBy",
                table: "CompanyLicenses",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyLicenses_UpdatedBy",
                table: "CompanyLicenses",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CreatedBy",
                table: "Countries",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DeletedBy",
                table: "Countries",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_UpdatedBy",
                table: "Countries",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_BranchId",
                table: "Departments",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CreatedBy",
                table: "Departments",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_DeletedBy",
                table: "Departments",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_UpdatedBy",
                table: "Departments",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityId",
                table: "Districts",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CreatedBy",
                table: "Districts",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_DeletedBy",
                table: "Districts",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_UpdatedBy",
                table: "Districts",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Addresses_BranchId",
                table: "GCard_Addresses",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Cards_OrderId",
                table: "GCard_Cards",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Cargos_BranchId",
                table: "GCard_Cargos",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Fields_BranchId",
                table: "GCard_Fields",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Ibans_BranchId",
                table: "GCard_Ibans",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Ibans_StaffId",
                table: "GCard_Ibans",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Invoices_BranchId",
                table: "GCard_Invoices",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Invoices_CardId",
                table: "GCard_Invoices",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_OrderDetails_BranchId",
                table: "GCard_OrderDetails",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_OrderDetails_CardId",
                table: "GCard_OrderDetails",
                column: "CardId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_OrderDetails_OrderId",
                table: "GCard_OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_OrderDetails_PurchasedForStaffId",
                table: "GCard_OrderDetails",
                column: "PurchasedForStaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_OrderDetails_StaffId",
                table: "GCard_OrderDetails",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Orders_AddressId",
                table: "GCard_Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Orders_BranchId",
                table: "GCard_Orders",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Orders_InvoiceId",
                table: "GCard_Orders",
                column: "InvoiceId",
                unique: true,
                filter: "[InvoiceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_PhoneNumbers_BranchId",
                table: "GCard_PhoneNumbers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_PhoneNumbers_StaffId",
                table: "GCard_PhoneNumbers",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_SocialMedias_BranchId",
                table: "GCard_SocialMedias",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_SocialMediaUrls_BranchId",
                table: "GCard_SocialMediaUrls",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_SocialMediaUrls_SocialMediaId",
                table: "GCard_SocialMediaUrls",
                column: "SocialMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_SocialMediaUrls_StaffId",
                table: "GCard_SocialMediaUrls",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffContacts_BranchId",
                table: "GCard_StaffContacts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffContacts_StaffId",
                table: "GCard_StaffContacts",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffFields_BranchId",
                table: "GCard_StaffFields",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffFields_FieldId",
                table: "GCard_StaffFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffFields_StaffId",
                table: "GCard_StaffFields",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_Staffs_BranchId",
                table: "GCard_Staffs",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCard_StaffStaffFile_StaffsId",
                table: "GCard_StaffStaffFile",
                column: "StaffsId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_AnnouncementDepartment_DepartmentsId",
                table: "GControl_AnnouncementDepartment",
                column: "DepartmentsId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_AnnouncementEmployeeLabel_EmployeeLabelsId",
                table: "GControl_AnnouncementEmployeeLabel",
                column: "EmployeeLabelsId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_ApplicationSettingEmployee_EmployeesId",
                table: "GControl_ApplicationSettingEmployee",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Department_BaseDepartmentId",
                table: "GControl_Department",
                column: "BaseDepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Department_LocationId",
                table: "GControl_Department",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EmployeeEmployeeFile_EmployeesId",
                table: "GControl_EmployeeEmployeeFile",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EmployeeEmployeeLabel_EmployeesId",
                table: "GControl_EmployeeEmployeeLabel",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Employees_BranchId",
                table: "GControl_Employees",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Employees_CompanyId",
                table: "GControl_Employees",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Employees_DepartmentId",
                table: "GControl_Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Employees_EmployeeTypeId",
                table: "GControl_Employees",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Employees_LocationId",
                table: "GControl_Employees",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EmployeeShiftManagement_ShiftManagementsId",
                table: "GControl_EmployeeShiftManagement",
                column: "ShiftManagementsId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EntryExitManagements_BranchId",
                table: "GControl_EntryExitManagements",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EntryExitManagements_CompanyId",
                table: "GControl_EntryExitManagements",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EntryExitManagements_EmployeeId",
                table: "GControl_EntryExitManagements",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_EntryExitManagements_LocationId",
                table: "GControl_EntryExitManagements",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_DepartmentManagers_EmployeeId",
                table: "GHR_DepartmentManagers",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EducationInfos_EmployeeId",
                table: "GHR_EducationInfos",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EmployeeRoles_EmployeeId",
                table: "GHR_EmployeeRoles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Employees_AppellationId",
                table: "GHR_Employees",
                column: "AppellationId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdvertPostedOn_JobAdvertId",
                table: "GHR_JobAdvertPostedOn",
                column: "JobAdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdverts_AppellationId",
                table: "GHR_JobAdverts",
                column: "AppellationId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicants_JobAdvertId",
                table: "GHR_JobApplicants",
                column: "JobAdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicants_JobApplicantDocumentId",
                table: "GHR_JobApplicants",
                column: "JobApplicantDocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_JobAdvertId",
                table: "GHR_JobApplications",
                column: "JobAdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_JobApplicantId",
                table: "GHR_JobApplications",
                column: "JobApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_JobApplicationStatusId",
                table: "GHR_JobApplications",
                column: "JobApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_RecruiterId",
                table: "GHR_JobApplications",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_RecruitmentProcessId",
                table: "GHR_JobApplications",
                column: "RecruitmentProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatusHistories_JobApplicationStatusId",
                table: "GHR_JobApplicationStatusHistories",
                column: "JobApplicationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobHistories_DepartmentId",
                table: "GHR_JobHistories",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobHistories_EmployeeId",
                table: "GHR_JobHistories",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Leaves_EmployeeId",
                table: "GHR_Leaves",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Leaves_LeaveTypeId",
                table: "GHR_Leaves",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Locations_JobAdvertId",
                table: "GHR_Locations",
                column: "JobAdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Notes_ApplicantId",
                table: "GHR_Notes",
                column: "ApplicantId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Notes_RecruiterId",
                table: "GHR_Notes",
                column: "RecruiterId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Payrolls_EmployeeId",
                table: "GHR_Payrolls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcessSteps_RecruitmentProcessId",
                table: "GHR_RecruitmentProcessSteps",
                column: "RecruitmentProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcessSteps_RecruitmentStepId",
                table: "GHR_RecruitmentProcessSteps",
                column: "RecruitmentStepId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentSteps_JobAdvertId",
                table: "GHR_RecruitmentSteps",
                column: "JobAdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RoleTypes_EmployeeRolesId",
                table: "GHR_RoleTypes",
                column: "EmployeeRolesId");

            migrationBuilder.CreateIndex(
                name: "IX_MailCredantials_BranchId",
                table: "MailCredantials",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MailCredantials_CreatedBy",
                table: "MailCredantials",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MailCredantials_DeletedBy",
                table: "MailCredantials",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MailCredantials_UpdatedBy",
                table: "MailCredantials",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_MailCredantials_UserId",
                table: "MailCredantials",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserAppUserFile_AspNetUsers_AppUsersId",
                table: "AppUserAppUserFile",
                column: "AppUsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserLicenses_AspNetUsers_AppUserId",
                table: "AppUserLicenses",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserLicenses_AspNetUsers_CreatedBy",
                table: "AppUserLicenses",
                column: "CreatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserLicenses_AspNetUsers_DeletedBy",
                table: "AppUserLicenses",
                column: "DeletedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserLicenses_AspNetUsers_UpdatedBy",
                table: "AppUserLicenses",
                column: "UpdatedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Departments_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCard_Cards_GCard_Orders_OrderId",
                table: "GCard_Cards",
                column: "OrderId",
                principalTable: "GCard_Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_CreatedBy",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_DeletedBy",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_AspNetUsers_UpdatedBy",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_AspNetUsers_CreatedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_AspNetUsers_DeletedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_AspNetUsers_UpdatedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_AppUserId",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_CreatedBy",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_DeletedBy",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_AspNetUsers_UpdatedBy",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_CreatedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_DeletedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_AspNetUsers_UpdatedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_CreatedBy",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_DeletedBy",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_AspNetUsers_UpdatedBy",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_AspNetUsers_CreatedBy",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_AspNetUsers_DeletedBy",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_AspNetUsers_UpdatedBy",
                table: "Districts");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Companies_CompanyId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_Branches_Districts_DistrictId",
                table: "Branches");

            migrationBuilder.DropForeignKey(
                name: "FK_GCard_Addresses_Branches_BranchId",
                table: "GCard_Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_GCard_Invoices_Branches_BranchId",
                table: "GCard_Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_GCard_Orders_Branches_BranchId",
                table: "GCard_Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_GCard_Cards_GCard_Orders_OrderId",
                table: "GCard_Cards");

            migrationBuilder.DropTable(
                name: "AppUserAppUserFile");

            migrationBuilder.DropTable(
                name: "AppUserLicenses");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CompanyCompanyFile");

            migrationBuilder.DropTable(
                name: "CompanyLicenses");

            migrationBuilder.DropTable(
                name: "GCard_Cargos");

            migrationBuilder.DropTable(
                name: "GCard_Ibans");

            migrationBuilder.DropTable(
                name: "GCard_OrderDetails");

            migrationBuilder.DropTable(
                name: "GCard_PasswordRemakes");

            migrationBuilder.DropTable(
                name: "GCard_PhoneNumbers");

            migrationBuilder.DropTable(
                name: "GCard_SocialMediaUrls");

            migrationBuilder.DropTable(
                name: "GCard_StaffContacts");

            migrationBuilder.DropTable(
                name: "GCard_StaffFields");

            migrationBuilder.DropTable(
                name: "GCard_StaffStaffFile");

            migrationBuilder.DropTable(
                name: "GControl_AnnouncementDepartment");

            migrationBuilder.DropTable(
                name: "GControl_AnnouncementEmployeeLabel");

            migrationBuilder.DropTable(
                name: "GControl_ApplicationSettingEmployee");

            migrationBuilder.DropTable(
                name: "GControl_EmployeeEmployeeFile");

            migrationBuilder.DropTable(
                name: "GControl_EmployeeEmployeeLabel");

            migrationBuilder.DropTable(
                name: "GControl_EmployeeShiftManagement");

            migrationBuilder.DropTable(
                name: "GControl_EntryExitManagements");

            migrationBuilder.DropTable(
                name: "GControl_PasswordRemakes");

            migrationBuilder.DropTable(
                name: "GControl_UserMainInfo");

            migrationBuilder.DropTable(
                name: "GHR_DepartmentManagers");

            migrationBuilder.DropTable(
                name: "GHR_EducationInfos");

            migrationBuilder.DropTable(
                name: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropTable(
                name: "GHR_JobApplications");

            migrationBuilder.DropTable(
                name: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropTable(
                name: "GHR_JobHistories");

            migrationBuilder.DropTable(
                name: "GHR_Leaves");

            migrationBuilder.DropTable(
                name: "GHR_Notes");

            migrationBuilder.DropTable(
                name: "GHR_Payrolls");

            migrationBuilder.DropTable(
                name: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropTable(
                name: "GHR_RoleTypes");

            migrationBuilder.DropTable(
                name: "GHR_SelfServices");

            migrationBuilder.DropTable(
                name: "MailCredantials");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GCard_SocialMedias");

            migrationBuilder.DropTable(
                name: "GCard_Fields");

            migrationBuilder.DropTable(
                name: "GCard_Staffs");

            migrationBuilder.DropTable(
                name: "GControl_Department");

            migrationBuilder.DropTable(
                name: "GControl_Announcement");

            migrationBuilder.DropTable(
                name: "GControl_ApplicationSettings");

            migrationBuilder.DropTable(
                name: "GControl_EmployeeLabels");

            migrationBuilder.DropTable(
                name: "GControl_ShiftManagements");

            migrationBuilder.DropTable(
                name: "GControl_Employees");

            migrationBuilder.DropTable(
                name: "GHR_JobApplicationStatuses");

            migrationBuilder.DropTable(
                name: "GHR_LeaveTypes");

            migrationBuilder.DropTable(
                name: "GHR_JobApplicants");

            migrationBuilder.DropTable(
                name: "GHR_Recruiters");

            migrationBuilder.DropTable(
                name: "GHR_RecruitmentProcesses");

            migrationBuilder.DropTable(
                name: "GHR_RecruitmentSteps");

            migrationBuilder.DropTable(
                name: "GHR_EmployeeRoles");

            migrationBuilder.DropTable(
                name: "GControl_EmployeeTypes");

            migrationBuilder.DropTable(
                name: "GControl_Locations");

            migrationBuilder.DropTable(
                name: "AppFiles");

            migrationBuilder.DropTable(
                name: "GHR_Employees");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "GHR_Locations");

            migrationBuilder.DropTable(
                name: "GHR_JobAdverts");

            migrationBuilder.DropTable(
                name: "GHR_Appellations");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "GCard_Orders");

            migrationBuilder.DropTable(
                name: "GCard_Addresses");

            migrationBuilder.DropTable(
                name: "GCard_Invoices");

            migrationBuilder.DropTable(
                name: "GCard_Cards");
        }
    }
}
