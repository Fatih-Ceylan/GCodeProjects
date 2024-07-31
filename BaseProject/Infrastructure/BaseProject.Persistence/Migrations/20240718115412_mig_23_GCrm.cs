using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_23_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_GCrm_Opportunities_OpportunityId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OpportunityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "AspNetUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_OpportunityId",
                table: "AspNetUsers",
                column: "OpportunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_GCrm_Opportunities_OpportunityId",
                table: "AspNetUsers",
                column: "OpportunityId",
                principalTable: "GCrm_Opportunities",
                principalColumn: "Id");
        }
    }
}
