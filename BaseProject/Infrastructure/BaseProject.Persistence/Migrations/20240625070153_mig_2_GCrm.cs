using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Projects_GCrm_PProjectStatues_ProjectStatuesId",
                table: "GCrm_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GCrm_PProjectStatues",
                table: "GCrm_PProjectStatues");

            migrationBuilder.RenameTable(
                name: "GCrm_PProjectStatues",
                newName: "GCrm_ProjectStatues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GCrm_ProjectStatues",
                table: "GCrm_ProjectStatues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Projects_GCrm_ProjectStatues_ProjectStatuesId",
                table: "GCrm_Projects",
                column: "ProjectStatuesId",
                principalTable: "GCrm_ProjectStatues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Projects_GCrm_ProjectStatues_ProjectStatuesId",
                table: "GCrm_Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GCrm_ProjectStatues",
                table: "GCrm_ProjectStatues");

            migrationBuilder.RenameTable(
                name: "GCrm_ProjectStatues",
                newName: "GCrm_PProjectStatues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GCrm_PProjectStatues",
                table: "GCrm_PProjectStatues",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Projects_GCrm_PProjectStatues_ProjectStatuesId",
                table: "GCrm_Projects",
                column: "ProjectStatuesId",
                principalTable: "GCrm_PProjectStatues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
