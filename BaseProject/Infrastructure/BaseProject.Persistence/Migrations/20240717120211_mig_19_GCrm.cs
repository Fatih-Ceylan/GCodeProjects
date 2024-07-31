using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_19_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OfferCustomerId",
                table: "GCrm_Opportunities",
                column: "OfferCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_TenderCustomerId",
                table: "GCrm_Opportunities",
                column: "TenderCustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Customers_OfferCustomerId",
                table: "GCrm_Opportunities",
                column: "OfferCustomerId",
                principalTable: "GCrm_Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Customers_TenderCustomerId",
                table: "GCrm_Opportunities",
                column: "TenderCustomerId",
                principalTable: "GCrm_Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Customers_OfferCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Customers_TenderCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OfferCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_TenderCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "OfferCustomerId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "TenderCustomerId",
                table: "GCrm_Opportunities");
        }
    }
}
