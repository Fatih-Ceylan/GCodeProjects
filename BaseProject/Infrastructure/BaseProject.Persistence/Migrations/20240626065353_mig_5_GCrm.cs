using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivitySubjectId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_Projects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_Projects",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_CustomerContacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_CustomerContacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchId",
                table: "GCrm_CustomerActivities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GCrm_CustomerActivities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffUrl",
                table: "GCard_Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Users_BranchId",
                table: "GCrm_Users",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Projects_BranchId",
                table: "GCrm_Projects",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_BranchId",
                table: "GCrm_Opportunities",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_BranchId",
                table: "GCrm_Customers",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerContacts_BranchId",
                table: "GCrm_CustomerContacts",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_BranchId",
                table: "GCrm_CustomerActivities",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivitySubjectId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivitySubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_CustomerActivities_Branches_BranchId",
                table: "GCrm_CustomerActivities",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_CustomerContacts_Branches_BranchId",
                table: "GCrm_CustomerContacts",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_Branches_BranchId",
                table: "GCrm_Customers",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_Branches_BranchId",
                table: "GCrm_Opportunities",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Projects_Branches_BranchId",
                table: "GCrm_Projects",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Users_Branches_BranchId",
                table: "GCrm_Users",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_CustomerActivities_Branches_BranchId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_CustomerContacts_Branches_BranchId",
                table: "GCrm_CustomerContacts");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_Branches_BranchId",
                table: "GCrm_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_Branches_BranchId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Projects_Branches_BranchId",
                table: "GCrm_Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Users_Branches_BranchId",
                table: "GCrm_Users");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Users_BranchId",
                table: "GCrm_Users");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Projects_BranchId",
                table: "GCrm_Projects");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_BranchId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Customers_BranchId",
                table: "GCrm_Customers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerContacts_BranchId",
                table: "GCrm_CustomerContacts");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerActivities_BranchId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivitySubjectId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_Users");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_Users");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_Projects");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_Projects");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_CustomerContacts");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_CustomerContacts");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GCrm_CustomerActivities");

            migrationBuilder.DropColumn(
                name: "StaffUrl",
                table: "GCard_Staffs");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerActivities_CustomerActivitySubjectId",
                table: "GCrm_CustomerActivities",
                column: "CustomerActivitySubjectId",
                unique: true);
        }
    }
}
