using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_GCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CargoTrackingNo",
                table: "GCard_Orders",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CargoTrackingNo",
                table: "GCard_Orders");
        }
    }
}
