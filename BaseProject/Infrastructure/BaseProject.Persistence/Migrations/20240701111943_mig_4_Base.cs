using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4_Base : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
              name: "DistrictId",
              table: "Companies",
              newName: "DistrictIdc");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_DistrictId",
                table: "Companies",
                newName: "IX_Companies_DistrictIdc");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Districts_DistrictIdc",
                table: "Companies",
                column: "DistrictIdc",
                principalTable: "Districts",
                principalColumn: "Idc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
              name: "DistrictIdc",
              table: "Companies",
              newName: "DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Companies_DistrictIdc",
                table: "Companies",
                newName: "IX_Companies_DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Districts_DistrictId",
                table: "Companies",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Idc");
        }
    }
}
