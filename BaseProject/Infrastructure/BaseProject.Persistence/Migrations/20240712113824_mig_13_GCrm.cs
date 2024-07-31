using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_13_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunityReferenceId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunitySectorId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityReferenceId",
                table: "GCrm_Opportunities",
                column: "OpportunityReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunitySectorId",
                table: "GCrm_Opportunities",
                column: "OpportunitySectorId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities",
                column: "OpportunityStageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunityReferenceId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunitySectorId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityReferenceId",
                table: "GCrm_Opportunities",
                column: "OpportunityReferenceId",
                unique: true,
                filter: "[OpportunityReferenceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunitySectorId",
                table: "GCrm_Opportunities",
                column: "OpportunitySectorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities",
                column: "OpportunityStageId",
                unique: true);
        }
    }
}
