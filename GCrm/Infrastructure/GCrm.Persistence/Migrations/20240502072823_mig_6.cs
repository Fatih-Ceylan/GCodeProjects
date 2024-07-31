using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GCrm.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerRepresentative",
                table: "Customers");

            migrationBuilder.AddColumn<Guid>(
                name: "CustomerRepresentativeId",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CustomerRepresentatives",
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
                    table.PrimaryKey("PK_CustomerRepresentatives", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CustomerRepresentativeId",
                table: "Customers",
                column: "CustomerRepresentativeId",
                unique: true,
                filter: "[CustomerRepresentativeId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_CustomerRepresentatives_CustomerRepresentativeId",
                table: "Customers",
                column: "CustomerRepresentativeId",
                principalTable: "CustomerRepresentatives",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_CustomerRepresentatives_CustomerRepresentativeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "CustomerRepresentatives");

            migrationBuilder.DropIndex(
                name: "IX_Customers_CustomerRepresentativeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerRepresentativeId",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "CustomerRepresentative",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
