using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_4_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "GCrm_CustomerAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "GCrm_CustomerAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerAddresses_DistrictId",
                table: "GCrm_CustomerAddresses",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_CustomerAddresses_Districts_DistrictId",
                table: "GCrm_CustomerAddresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Idc");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_CustomerAddresses_Districts_DistrictId",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerAddresses_DistrictId",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "GCrm_CustomerAddresses");
        }
    }
}
