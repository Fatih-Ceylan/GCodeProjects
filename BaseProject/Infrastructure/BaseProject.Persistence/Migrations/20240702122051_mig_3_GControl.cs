using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_3_GControl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GControl_ShiftManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GControl_ApplicationSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "GControl_Announcement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GControl_ShiftManagements_CompanyId",
                table: "GControl_ShiftManagements",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_ApplicationSettings_CompanyId",
                table: "GControl_ApplicationSettings",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Announcement_CompanyId",
                table: "GControl_Announcement",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_GControl_Announcement_Companies_CompanyId",
                table: "GControl_Announcement",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GControl_ApplicationSettings_Companies_CompanyId",
                table: "GControl_ApplicationSettings",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GControl_ShiftManagements_Companies_CompanyId",
                table: "GControl_ShiftManagements",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GControl_Announcement_Companies_CompanyId",
                table: "GControl_Announcement");

            migrationBuilder.DropForeignKey(
                name: "FK_GControl_ApplicationSettings_Companies_CompanyId",
                table: "GControl_ApplicationSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_GControl_ShiftManagements_Companies_CompanyId",
                table: "GControl_ShiftManagements");

            migrationBuilder.DropIndex(
                name: "IX_GControl_ShiftManagements_CompanyId",
                table: "GControl_ShiftManagements");

            migrationBuilder.DropIndex(
                name: "IX_GControl_ApplicationSettings_CompanyId",
                table: "GControl_ApplicationSettings");

            migrationBuilder.DropIndex(
                name: "IX_GControl_Announcement_CompanyId",
                table: "GControl_Announcement");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GControl_ShiftManagements");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GControl_ApplicationSettings");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "GControl_Announcement");
        }
    }
}
