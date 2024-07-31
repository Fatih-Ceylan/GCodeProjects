using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_25_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "GCrm_Customers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_AppUserId",
                table: "GCrm_Customers",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_AppUserId",
                table: "GCrm_Customers",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_AspNetUsers_AppUserId",
                table: "GCrm_Customers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Customers_AppUserId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "GCrm_Customers");
        }
    }
}
