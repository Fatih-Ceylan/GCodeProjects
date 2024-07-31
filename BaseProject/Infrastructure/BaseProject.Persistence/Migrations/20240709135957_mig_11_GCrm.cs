using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_11_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityStageId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "GCrm_OpportunityStages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GCrm_OpportunityStages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities",
                column: "OpportunityStageId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_OpportunityStages_OpportunityStageId",
                table: "GCrm_Opportunities",
                column: "OpportunityStageId",
                principalTable: "GCrm_OpportunityStages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_OpportunityStages_OpportunityStageId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropTable(
                name: "GCrm_OpportunityStages");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_OpportunityStageId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "OpportunityStageId",
                table: "GCrm_Opportunities");
        }
    }
}
