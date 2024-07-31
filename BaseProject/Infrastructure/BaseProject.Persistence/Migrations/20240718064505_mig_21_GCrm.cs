using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_21_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.CreateTable(
                name: "CustomerContactOpportunity",
                columns: table => new
                {
                    CustomerContactsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OpportunitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerContactOpportunity", x => new { x.CustomerContactsId, x.OpportunitiesId });
                    table.ForeignKey(
                        name: "FK_CustomerContactOpportunity_GCrm_CustomerContacts_CustomerContactsId",
                        column: x => x.CustomerContactsId,
                        principalTable: "GCrm_CustomerContacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerContactOpportunity_GCrm_Opportunities_OpportunitiesId",
                        column: x => x.OpportunitiesId,
                        principalTable: "GCrm_Opportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerContactOpportunity_OpportunitiesId",
                table: "CustomerContactOpportunity",
                column: "OpportunitiesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerContactOpportunity");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId",
                principalTable: "GCrm_CustomerContacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
