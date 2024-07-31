using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_30_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_AppUserId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "GCrm_Opportunities",
                newName: "SalesUserId1");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Opportunities_AppUserId",
                table: "GCrm_Opportunities",
                newName: "IX_GCrm_Opportunities_SalesUserId1");

            migrationBuilder.AddColumn<Guid>(
                name: "SalesUserId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SalesUserId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "SalesUserId1",
                table: "GCrm_Opportunities",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Opportunities_SalesUserId1",
                table: "GCrm_Opportunities",
                newName: "IX_GCrm_Opportunities_AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_AppUserId",
                table: "GCrm_Opportunities",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
