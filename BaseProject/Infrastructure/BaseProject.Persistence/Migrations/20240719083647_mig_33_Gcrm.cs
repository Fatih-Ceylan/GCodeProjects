using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_33_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId1",
                table: "GCrm_Customers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId1",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId1",
                table: "GCrm_Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "CustomerRepresentativeId1",
                table: "GCrm_Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId1",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId1",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
