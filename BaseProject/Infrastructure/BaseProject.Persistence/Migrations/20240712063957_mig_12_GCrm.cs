using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_12_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyContactNames_CompanyContactNameId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyOffers_CompanyOfferId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyTenders_CompanyTenderId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CompanyOfferId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CompanyTenderId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "CompanyTenderId",
                table: "GCrm_Opportunities",
                newName: "TenderCompanyId");

            migrationBuilder.RenameColumn(
                name: "CompanyOfferId",
                table: "GCrm_Opportunities",
                newName: "OfferCompanyId");

            migrationBuilder.RenameColumn(
                name: "CompanyContactNameId",
                table: "GCrm_Opportunities",
                newName: "CustomerContactId");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Opportunities_CompanyContactNameId",
                table: "GCrm_Opportunities",
                newName: "IX_GCrm_Opportunities_CustomerContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId",
                principalTable: "GCrm_CustomerContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "TenderCompanyId",
                table: "GCrm_Opportunities",
                newName: "CompanyTenderId");

            migrationBuilder.RenameColumn(
                name: "OfferCompanyId",
                table: "GCrm_Opportunities",
                newName: "CompanyOfferId");

            migrationBuilder.RenameColumn(
                name: "CustomerContactId",
                table: "GCrm_Opportunities",
                newName: "CompanyContactNameId");

            migrationBuilder.RenameIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities",
                newName: "IX_GCrm_Opportunities_CompanyContactNameId");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyOfferId",
                table: "GCrm_Opportunities",
                column: "CompanyOfferId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CompanyTenderId",
                table: "GCrm_Opportunities",
                column: "CompanyTenderId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyContactNames_CompanyContactNameId",
                table: "GCrm_Opportunities",
                column: "CompanyContactNameId",
                principalTable: "GCrm_CompanyContactNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyOffers_CompanyOfferId",
                table: "GCrm_Opportunities",
                column: "CompanyOfferId",
                principalTable: "GCrm_CompanyOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CompanyTenders_CompanyTenderId",
                table: "GCrm_Opportunities",
                column: "CompanyTenderId",
                principalTable: "GCrm_CompanyTenders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
