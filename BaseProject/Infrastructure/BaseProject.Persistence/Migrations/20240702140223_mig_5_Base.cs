using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_5_Base : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Companies_Districts_DistrictIdc",
                table: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Companies_DistrictIdc",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "DistrictIdc",
                table: "Companies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistrictIdc",
                table: "Companies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_DistrictIdc",
                table: "Companies",
                column: "DistrictIdc");

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_Districts_DistrictIdc",
                table: "Companies",
                column: "DistrictIdc",
                principalTable: "Districts",
                principalColumn: "Idc");
        }
    }
}
