using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_34_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers");
        }
    }
}
