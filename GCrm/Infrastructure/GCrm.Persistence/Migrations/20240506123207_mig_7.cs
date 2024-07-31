using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCrm.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Process",
                table: "CustomerGroup");

            migrationBuilder.CreateTable(
                name: "UserBranch",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_UserBranch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_UserLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsersDepartment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_UsersDepartment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTitle",
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
                    table.PrimaryKey("PK_UserTitle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<int>(type: "int", nullable: false),
                    UserPasswordRepeat = table.Column<int>(type: "int", nullable: false),
                    DataTransfer = table.Column<bool>(type: "bit", nullable: false),
                    UserCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserLocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserBranchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UsersDepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserBranch_UserBranchId",
                        column: x => x.UserBranchId,
                        principalTable: "UserBranch",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserLocation_UserLocationId",
                        column: x => x.UserLocationId,
                        principalTable: "UserLocation",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UserTitle_UserTitleId",
                        column: x => x.UserTitleId,
                        principalTable: "UserTitle",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Users_UsersDepartment_UsersDepartmentId",
                        column: x => x.UsersDepartmentId,
                        principalTable: "UsersDepartment",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserBranchId",
                table: "Users",
                column: "UserBranchId",
                unique: true,
                filter: "[UserBranchId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserLocationId",
                table: "Users",
                column: "UserLocationId",
                unique: true,
                filter: "[UserLocationId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UsersDepartmentId",
                table: "Users",
                column: "UsersDepartmentId",
                unique: true,
                filter: "[UsersDepartmentId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTitleId",
                table: "Users",
                column: "UserTitleId",
                unique: true,
                filter: "[UserTitleId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserBranch");

            migrationBuilder.DropTable(
                name: "UserLocation");

            migrationBuilder.DropTable(
                name: "UserTitle");

            migrationBuilder.DropTable(
                name: "UsersDepartment");

            migrationBuilder.AddColumn<string>(
                name: "Process",
                table: "CustomerGroup",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
