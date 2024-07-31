using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_15_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyId",
                table: "GCrm_Opportunities",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_Companies_CompanyId",
                table: "GCrm_Opportunities",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_Companies_CompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CompanyId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId",
                unique: true);
        }
    }
}
