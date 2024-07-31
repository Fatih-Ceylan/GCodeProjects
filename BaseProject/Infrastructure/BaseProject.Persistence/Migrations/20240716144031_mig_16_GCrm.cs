using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_16_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_Companies_TenderCompanyId",
                table: "GCrm_Opportunities",
                column: "TenderCompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
