using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_CustomerAddresses_Districts_DistrictIdc",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_CustomerAddresses_DistrictIdc",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "DistrictIdc",
                table: "GCrm_CustomerAddresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CityId",
                table: "GCrm_CustomerAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DistrictId",
                table: "GCrm_CustomerAddresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictIdc",
                table: "GCrm_CustomerAddresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_CustomerAddresses_DistrictIdc",
                table: "GCrm_CustomerAddresses",
                column: "DistrictIdc");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_CustomerAddresses_Districts_DistrictIdc",
                table: "GCrm_CustomerAddresses",
                column: "DistrictIdc",
                principalTable: "Districts",
                principalColumn: "Idc",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
