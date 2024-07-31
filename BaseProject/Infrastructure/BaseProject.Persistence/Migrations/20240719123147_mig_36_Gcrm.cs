using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_36_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email1",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Email2",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "FaxNo",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.DropColumn(
                name: "WebAddress",
                table: "GCrm_CustomerAddresses");

            migrationBuilder.AddColumn<string>(
                name: "Email1",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxNo",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebAddress",
                table: "GCrm_Customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email1",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "Email2",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "FaxNo",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "Phone2",
                table: "GCrm_Customers");

            migrationBuilder.DropColumn(
                name: "WebAddress",
                table: "GCrm_Customers");

            migrationBuilder.AddColumn<string>(
                name: "Email1",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email2",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxNo",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone2",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebAddress",
                table: "GCrm_CustomerAddresses",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
