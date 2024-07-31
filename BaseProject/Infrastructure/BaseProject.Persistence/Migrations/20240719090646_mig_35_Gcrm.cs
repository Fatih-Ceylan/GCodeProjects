using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_35_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SalesUserId",
                table: "GCrm_Opportunities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_SalesUserId",
                table: "GCrm_Opportunities",
                column: "SalesUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId",
                table: "GCrm_Opportunities",
                column: "SalesUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_SalesUserId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SalesUserId",
                table: "GCrm_Opportunities");
        }
    }
}
