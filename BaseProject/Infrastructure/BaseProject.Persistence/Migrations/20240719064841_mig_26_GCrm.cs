using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_26_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Customers_GCrm_CustomerRepresentatives_CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CustomerRepresentativeId",
                table: "GCrm_Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Customers_CustomerRepresentativeId",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Customers_GCrm_CustomerRepresentatives_CustomerRepresentativeId",
                table: "GCrm_Customers",
                column: "CustomerRepresentativeId",
                principalTable: "GCrm_CustomerRepresentatives",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
