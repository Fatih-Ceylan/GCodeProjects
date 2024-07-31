using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_24_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerContactId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "OfferCustomerContactId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities",
                column: "CustomerContactId",
                principalTable: "GCrm_CustomerContacts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_CustomerContacts_CustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "OfferCustomerContactId",
                table: "GCrm_Opportunities");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerContactId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
