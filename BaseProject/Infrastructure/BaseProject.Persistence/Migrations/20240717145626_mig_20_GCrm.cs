using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_20_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GCrm_OpportunityUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_UsersId",
                table: "GCrm_Opportunities",
                column: "UsersId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Users_UsersId",
                table: "GCrm_Opportunities",
                column: "UsersId",
                principalTable: "GCrm_Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_GCrm_Opportunities_OpportunityId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_Users_UsersId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_UsersId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_OpportunityId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "GCrm_OpportunityUsers",
                columns: table => new
                {
                    OpportunitiesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_OpportunityUsers", x => new { x.OpportunitiesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GCrm_OpportunityUsers_GCrm_Opportunities_OpportunitiesId",
                        column: x => x.OpportunitiesId,
                        principalTable: "GCrm_Opportunities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GCrm_OpportunityUsers_GCrm_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "GCrm_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_OpportunityUsers_UsersId",
                table: "GCrm_OpportunityUsers",
                column: "UsersId");
        }
    }
}
