using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_GControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GControl_Locations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Locations_CompanyId",
                table: "GControl_Locations",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_GControl_Locations_Companies_CompanyId",
                table: "GControl_Locations",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GControl_Locations_Companies_CompanyId",
                table: "GControl_Locations");

            migrationBuilder.DropIndex(
                name: "IX_GControl_Locations_CompanyId",
                table: "GControl_Locations");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GControl_Locations");
        }
    }
}
