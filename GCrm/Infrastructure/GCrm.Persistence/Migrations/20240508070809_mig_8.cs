using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCrm.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContacts_DecisionStatuses_DecisionStatusId",
                table: "CustomerContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerContacts_RelationWithCompanies_RelationWithCompanyId",
                table: "CustomerContacts");

            migrationBuilder.DropTable(
                name: "DecisionStatuses");

            migrationBuilder.DropTable(
                name: "RelationWithCompanies");

            migrationBuilder.DropIndex(
                name: "IX_CustomerContacts_DecisionStatusId",
                table: "CustomerContacts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerContacts_RelationWithCompanyId",
                table: "CustomerContacts");

            migrationBuilder.DropColumn(
                name: "DecisionStatusId",
                table: "CustomerContacts");

            migrationBuilder.DropColumn(
                name: "RelationWithCompanyId",
                table: "CustomerContacts");

            migrationBuilder.AddColumn<int>(
                name: "DecisionStatus",
                table: "CustomerContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RelationCompany",
                table: "CustomerContacts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DecisionStatus",
                table: "CustomerContacts");

            migrationBuilder.DropColumn(
                name: "RelationCompany",
                table: "CustomerContacts");

            migrationBuilder.AddColumn<Guid>(
                name: "DecisionStatusId",
                table: "CustomerContacts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "RelationWithCompanyId",
                table: "CustomerContacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DecisionStatuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DecisionStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RelationWithCompanies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelationWithCompanies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_DecisionStatusId",
                table: "CustomerContacts",
                column: "DecisionStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContacts_RelationWithCompanyId",
                table: "CustomerContacts",
                column: "RelationWithCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContacts_DecisionStatuses_DecisionStatusId",
                table: "CustomerContacts",
                column: "DecisionStatusId",
                principalTable: "DecisionStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerContacts_RelationWithCompanies_RelationWithCompanyId",
                table: "CustomerContacts",
                column: "RelationWithCompanyId",
                principalTable: "RelationWithCompanies",
                principalColumn: "Id");
        }
    }
}
