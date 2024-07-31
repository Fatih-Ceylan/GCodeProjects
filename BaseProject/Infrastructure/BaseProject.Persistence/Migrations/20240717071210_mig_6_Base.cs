using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6_Base : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_GHR_Locations_LocationId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_GControl_Department_BaseDepartmentId",
                table: "GControl_Department");

            migrationBuilder.DropIndex(
                name: "IX_Departments_LocationId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Departments");

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Department_BaseDepartmentId",
                table: "GControl_Department",
                column: "BaseDepartmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GControl_Department_BaseDepartmentId",
                table: "GControl_Department");

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GControl_Department_BaseDepartmentId",
                table: "GControl_Department",
                column: "BaseDepartmentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_LocationId",
                table: "Departments",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_GHR_Locations_LocationId",
                table: "Departments",
                column: "LocationId",
                principalTable: "GHR_Locations",
                principalColumn: "Id");
        }
    }
}
