using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_18_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfferCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "TenderCustomerId",
                table: "GCrm_Opportunities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OfferCustomerId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "TenderCustomerId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
