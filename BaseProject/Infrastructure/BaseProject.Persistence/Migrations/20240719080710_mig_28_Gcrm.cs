using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_28_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_AppUserId",
                table: "GCrm_Customers");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "GCrm_Customers",
                newName: "CustomerRepresentativeId1");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Customers_AppUserId",
                table: "GCrm_Customers",
                newName: "IX_GCrm_Customers_CustomerRepresentativeId1");

            migrationBuilder.AddColumn<string>(
                name: "SalesUserId1",
                table: "GCrm_Opportunities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_SalesUserId1",
                table: "GCrm_Opportunities",
                column: "SalesUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId1",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId1",
                table: "GCrm_Opportunities",
                column: "SalesUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId1",
                table: "GCrm_Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerRepresentativeId1",
                table: "GCrm_Customers",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId1",
                table: "GCrm_Customers",
                newName: "IX_GCrm_Customers_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_AppUserId",
                table: "GCrm_Customers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
