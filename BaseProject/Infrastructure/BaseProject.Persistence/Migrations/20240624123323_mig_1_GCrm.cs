using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GCrm_CompanyContactNames",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CompanyContactNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CompanyOffers",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CompanyOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CompanyTenders",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CompanyTenders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivityKinds",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivityKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivityStatuses",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivityStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivitySubjects",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivitySubjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivityTypes",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerCategories",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerGroups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerGroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGroupType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerKinds",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerKinds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerRepresentatives",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerRepresentatives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerSectors",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerSectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerSources",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerStatuses",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerTypes",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_OpportunityReferences",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_OpportunityReferences", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_OpportunitySectors",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_OpportunitySectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_PProjectStatues",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_PProjectStatues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProjectManagers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProjectManagers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProjectTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTeamName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProjectTeams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProjectType",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProjectType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_SolutionOffers",
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_SolutionOffers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_UserTitle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TitleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_UserTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DefaultContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerKindId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerRepresentativeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerSectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrackStatus = table.Column<bool>(type: "bit", nullable: false),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentType = table.Column<int>(type: "int", nullable: true),
                    CurrencyType = table.Column<int>(type: "int", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskStatus = table.Column<int>(type: "int", nullable: true),
                    SkypeAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkedinAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacebookAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwitterAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerRating = table.Column<double>(type: "float", nullable: true),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerFileId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_AppFiles_CustomerFileId",
                        column: x => x.CustomerFileId,
                        principalTable: "AppFiles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerGroups_CustomerGroupId",
                        column: x => x.CustomerGroupId,
                        principalTable: "GCrm_CustomerGroups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerKinds_CustomerKindId",
                        column: x => x.CustomerKindId,
                        principalTable: "GCrm_CustomerKinds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerRepresentatives_CustomerRepresentativeId",
                        column: x => x.CustomerRepresentativeId,
                        principalTable: "GCrm_CustomerRepresentatives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerSectors_CustomerSectorId",
                        column: x => x.CustomerSectorId,
                        principalTable: "GCrm_CustomerSectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerSources_CustomerSourceId",
                        column: x => x.CustomerSourceId,
                        principalTable: "GCrm_CustomerSources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerStatuses_CustomerStatusId",
                        column: x => x.CustomerStatusId,
                        principalTable: "GCrm_CustomerStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Customers_GCrm_CustomerTypes_CustomerTypeId",
                        column: x => x.CustomerTypeId,
                        principalTable: "GCrm_CustomerTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCrm_Opportunities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpportunitySubject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpportunitySectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyTenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyContactNameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TenderBroadcastDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SpecificationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinalOfferDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RemainingTime = table.Column<int>(type: "int", nullable: true),
                    SolutionOfferId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrandsOffered = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpportunityReferenceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ReferrerPerson = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpportunityTotalAmount = table.Column<int>(type: "int", nullable: true),
                    CurrencyTypeEnum = table.Column<int>(type: "int", nullable: true),
                    PotentialAmount = table.Column<int>(type: "int", nullable: true),
                    OpportunityStageEnum = table.Column<int>(type: "int", nullable: true),
                    OpportunityStatu = table.Column<int>(type: "int", nullable: true),
                    ProbabilityWinning = table.Column<int>(type: "int", nullable: true),
                    EstimatedEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OpportunityLocation = table.Column<int>(type: "int", nullable: true),
                    ActionTaken = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_Opportunities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_CompanyContactNames_CompanyContactNameId",
                        column: x => x.CompanyContactNameId,
                        principalTable: "GCrm_CompanyContactNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_CompanyOffers_CompanyOfferId",
                        column: x => x.CompanyOfferId,
                        principalTable: "GCrm_CompanyOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_CompanyTenders_CompanyTenderId",
                        column: x => x.CompanyTenderId,
                        principalTable: "GCrm_CompanyTenders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_OpportunityReferences_OpportunityReferenceId",
                        column: x => x.OpportunityReferenceId,
                        principalTable: "GCrm_OpportunityReferences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_OpportunitySectors_OpportunitySectorId",
                        column: x => x.OpportunitySectorId,
                        principalTable: "GCrm_OpportunitySectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Opportunities_GCrm_SolutionOffers_SolutionOfferId",
                        column: x => x.SolutionOfferId,
                        principalTable: "GCrm_SolutionOffers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<int>(type: "int", nullable: false),
                    UserPasswordRepeat = table.Column<int>(type: "int", nullable: false),
                    DataTransfer = table.Column<bool>(type: "bit", nullable: false),
                    UserCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserTitleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PriceNameEnum = table.Column<int>(type: "int", nullable: false),
                    GenderEnum = table.Column<int>(type: "int", nullable: false),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartWorkhDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishWorkhDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroupEnum = table.Column<int>(type: "int", nullable: false),
                    EducationalStatuEnum = table.Column<int>(type: "int", nullable: false),
                    GraduationSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduationFacultyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GraduationSchoolDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaritalStatusEnum = table.Column<int>(type: "int", nullable: false),
                    MarriageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BankAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserStatuEnum = table.Column<int>(type: "int", nullable: false),
                    AdminUser = table.Column<bool>(type: "bit", nullable: false),
                    UserPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserSignature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DeletedByUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_Users_AspNetUsers_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Users_AspNetUsers_DeletedByUserId",
                        column: x => x.DeletedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Users_AspNetUsers_UpdatedByUserId",
                        column: x => x.UpdatedByUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_Users_GCrm_UserTitle_UserTitleId",
                        column: x => x.UserTitleId,
                        principalTable: "GCrm_UserTitle",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerAddresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AddressType = table.Column<int>(type: "int", nullable: false),
                    Address1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DistrictId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictIdc = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerAddresses_Districts_DistrictIdc",
                        column: x => x.DistrictIdc,
                        principalTable: "Districts",
                        principalColumn: "Idc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerAddresses_GCrm_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "GCrm_Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerContacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InternalNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FaxNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressType = table.Column<int>(type: "int", nullable: true),
                    DecisionStatus = table.Column<int>(type: "int", nullable: false),
                    RelationCompany = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaritalStatus = table.Column<int>(type: "int", nullable: true),
                    MarriageDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AssistantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssistantPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardVisitImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerContacts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerContacts_GCrm_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "GCrm_Customers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomersCustomerCategories",
                columns: table => new
                {
                    CustomerCategoriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomersCustomerCategories", x => new { x.CustomerCategoriesId, x.CustomersId });
                    table.ForeignKey(
                        name: "FK_GCrm_CustomersCustomerCategories_GCrm_CustomerCategories_CustomerCategoriesId",
                        column: x => x.CustomerCategoriesId,
                        principalTable: "GCrm_CustomerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomersCustomerCategories_GCrm_Customers_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "GCrm_Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_Projects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectManagerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStatuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectFinishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectPriorityEnum = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_Projects_GCrm_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "GCrm_Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Projects_GCrm_PProjectStatues_ProjectStatuesId",
                        column: x => x.ProjectStatuesId,
                        principalTable: "GCrm_PProjectStatues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Projects_GCrm_ProjectManagers_ProjectManagerId",
                        column: x => x.ProjectManagerId,
                        principalTable: "GCrm_ProjectManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Projects_GCrm_ProjectTeams_ProjectTeamId",
                        column: x => x.ProjectTeamId,
                        principalTable: "GCrm_ProjectTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_Projects_GCrm_ProjectType_ProjectTypeId",
                        column: x => x.ProjectTypeId,
                        principalTable: "GCrm_ProjectType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_OpportunityUsers",
                columns: table => new
                {
                    OpportunitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_OpportunityUsers", x => new { x.OpportunitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GCrm_OpportunityUsers_GCrm_Opportunities_OpportunitiesId",
                        column: x => x.OpportunitiesId,
                        principalTable: "GCrm_Opportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_OpportunityUsers_GCrm_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "GCrm_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerContactId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerActivitySubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerActivityTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerActivityKindId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerActivityStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReminderDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfferCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpportunityCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailStatus = table.Column<bool>(type: "bit", nullable: false),
                    ActivityAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_CustomerActivityKinds_CustomerActivityKindId",
                        column: x => x.CustomerActivityKindId,
                        principalTable: "GCrm_CustomerActivityKinds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_CustomerActivityStatuses_CustomerActivityStatusId",
                        column: x => x.CustomerActivityStatusId,
                        principalTable: "GCrm_CustomerActivityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_CustomerActivitySubjects_CustomerActivitySubjectId",
                        column: x => x.CustomerActivitySubjectId,
                        principalTable: "GCrm_CustomerActivitySubjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_CustomerActivityTypes_CustomerActivityTypeId",
                        column: x => x.CustomerActivityTypeId,
                        principalTable: "GCrm_CustomerActivityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_CustomerContacts_CustomerContactId",
                        column: x => x.CustomerContactId,
                        principalTable: "GCrm_CustomerContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivities_GCrm_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "GCrm_Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_ProjectProjectFiles",
                columns: table => new
                {
                    ProjectFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_ProjectProjectFiles", x => new { x.ProjectFilesId, x.ProjectsId });
                    table.ForeignKey(
                        name: "FK_GCrm_ProjectProjectFiles_AppFiles_ProjectFilesId",
                        column: x => x.ProjectFilesId,
                        principalTable: "AppFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_ProjectProjectFiles_GCrm_Projects_ProjectsId",
                        column: x => x.ProjectsId,
                        principalTable: "GCrm_Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GCrm_CustomerActivityTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CustomerActivityTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_CustomerActivityTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivityTeams_GCrm_CustomerActivities_CustomerActivityId",
                        column: x => x.CustomerActivityId,
                        principalTable: "GCrm_CustomerActivities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GCrm_CustomerActivityTeams_GCrm_CustomerActivityTeams_CustomerActivityTeamId",
                        column: x => x.CustomerActivityTeamId,
                        principalTable: "GCrm_CustomerActivityTeams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivityKindId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivityKindId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivityStatusId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivitySubjectId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivitySubjectId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivityTypeId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerContactId",
                table: "GCrm_CustomerActivities",
                column: "CustomerContactId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerId",
                table: "GCrm_CustomerActivities",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivityTeams_CustomerActivityId",
                table: "GCrm_CustomerActivityTeams",
                column: "CustomerActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivityTeams_CustomerActivityTeamId",
                table: "GCrm_CustomerActivityTeams",
                column: "CustomerActivityTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerAddresses_CustomerId",
                table: "GCrm_CustomerAddresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerAddresses_DistrictIdc",
                table: "GCrm_CustomerAddresses",
                column: "DistrictIdc");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerContacts_CustomerId",
                table: "GCrm_CustomerContacts",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerFileId",
                table: "GCrm_Customers",
                column: "CustomerFileId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerGroupId",
                table: "GCrm_Customers",
                column: "CustomerGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerKindId",
                table: "GCrm_Customers",
                column: "CustomerKindId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerSectorId",
                table: "GCrm_Customers",
                column: "CustomerSectorId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerSourceId",
                table: "GCrm_Customers",
                column: "CustomerSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerStatusId",
                table: "GCrm_Customers",
                column: "CustomerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerTypeId",
                table: "GCrm_Customers",
                column: "CustomerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomersCustomerCategories_CustomersId",
                table: "GCrm_CustomersCustomerCategories",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyContactNameId",
                table: "GCrm_Opportunities",
                column: "CompanyContactNameId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyOfferId",
                table: "GCrm_Opportunities",
                column: "CompanyOfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyTenderId",
                table: "GCrm_Opportunities",
                column: "CompanyTenderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityReferenceId",
                table: "GCrm_Opportunities",
                column: "OpportunityReferenceId",
                unique: true,
                filter: "[OpportunityReferenceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunitySectorId",
                table: "GCrm_Opportunities",
                column: "OpportunitySectorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_SolutionOfferId",
                table: "GCrm_Opportunities",
                column: "SolutionOfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_OpportunityUsers_UsersId",
                table: "GCrm_OpportunityUsers",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_ProjectProjectFiles_ProjectsId",
                table: "GCrm_ProjectProjectFiles",
                column: "ProjectsId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_CustomerId",
                table: "GCrm_Projects",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_ProjectManagerId",
                table: "GCrm_Projects",
                column: "ProjectManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_ProjectStatuesId",
                table: "GCrm_Projects",
                column: "ProjectStatuesId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_ProjectTeamId",
                table: "GCrm_Projects",
                column: "ProjectTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_ProjectTypeId",
                table: "GCrm_Projects",
                column: "ProjectTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Users_CreatedByUserId",
                table: "GCrm_Users",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Users_DeletedByUserId",
                table: "GCrm_Users",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Users_UpdatedByUserId",
                table: "GCrm_Users",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Users_UserTitleId",
                table: "GCrm_Users",
                column: "UserTitleId",
                unique: true,
                filter: "[UserTitleId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivityTeams");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerAddresses");

            migrationBuilder.DropTable(
                name: "GCrm_CustomersCustomerCategories");

            migrationBuilder.DropTable(
                name: "GCrm_OpportunityUsers");

            migrationBuilder.DropTable(
                name: "GCrm_ProjectProjectFiles");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivities");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerCategories");

            migrationBuilder.DropTable(
                name: "GCrm_Opportunities");

            migrationBuilder.DropTable(
                name: "GCrm_Users");

            migrationBuilder.DropTable(
                name: "GCrm_Projects");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivityKinds");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivityStatuses");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivitySubjects");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerActivityTypes");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerContacts");

            migrationBuilder.DropTable(
                name: "GCrm_CompanyContactNames");

            migrationBuilder.DropTable(
                name: "GCrm_CompanyOffers");

            migrationBuilder.DropTable(
                name: "GCrm_CompanyTenders");

            migrationBuilder.DropTable(
                name: "GCrm_OpportunityReferences");

            migrationBuilder.DropTable(
                name: "GCrm_OpportunitySectors");

            migrationBuilder.DropTable(
                name: "GCrm_SolutionOffers");

            migrationBuilder.DropTable(
                name: "GCrm_UserTitle");

            migrationBuilder.DropTable(
                name: "GCrm_PProjectStatues");

            migrationBuilder.DropTable(
                name: "GCrm_ProjectManagers");

            migrationBuilder.DropTable(
                name: "GCrm_ProjectTeams");

            migrationBuilder.DropTable(
                name: "GCrm_ProjectType");

            migrationBuilder.DropTable(
                name: "GCrm_Customers");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerGroups");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerKinds");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerRepresentatives");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerSectors");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerSources");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerStatuses");

            migrationBuilder.DropTable(
                name: "GCrm_CustomerTypes");
        }
    }
}
