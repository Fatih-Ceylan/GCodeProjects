using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_17_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_Companies_OfferCompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_Companies_TenderCompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OfferCompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_TenderCompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "TenderCompanyId",
                table: "GCrm_Opportunities",
                newName: "TenderCustomerId");

            migrationBuilder.RenameColumn(
                name: "OfferCompanyId",
                table: "GCrm_Opportunities",
                newName: "OfferCustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TenderCustomerId",
                table: "GCrm_Opportunities",
                newName: "TenderCompanyId");

            migrationBuilder.RenameColumn(
                name: "OfferCustomerId",
                table: "GCrm_Opportunities",
                newName: "OfferCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OfferCompanyId",
                table: "GCrm_Opportunities",
                column: "OfferCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_TenderCompanyId",
                table: "GCrm_Opportunities",
                column: "TenderCompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_Companies_OfferCompanyId",
                table: "GCrm_Opportunities",
                column: "OfferCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_Companies_TenderCompanyId",
                table: "GCrm_Opportunities",
                column: "TenderCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
