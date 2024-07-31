using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_8_GCrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_SolutionOffers_SolutionOfferId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_SolutionOfferId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SolutionOfferId",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "CurrencyTypeEnum",
                table: "GCrm_Opportunities",
                newName: "PotentialAmountEnum");

            migrationBuilder.AddColumn<Guid>(
                name: "OpportunityId",
                table: "GCrm_SolutionOffers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<decimal>(
                name: "PotentialAmount",
                table: "GCrm_Opportunities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OpportunityTotalAmount",
                table: "GCrm_Opportunities",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpportunityLocation",
                table: "GCrm_Opportunities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActionTaken",
                table: "GCrm_Opportunities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpportunityTotalAmountEnum",
                table: "GCrm_Opportunities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SolutionOffer",
                table: "GCrm_Opportunities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_SolutionOffers_OpportunityId",
                table: "GCrm_SolutionOffers",
                column: "OpportunityId");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_SolutionOffers_GCrm_Opportunities_OpportunityId",
                table: "GCrm_SolutionOffers",
                column: "OpportunityId",
                principalTable: "GCrm_Opportunities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_SolutionOffers_GCrm_Opportunities_OpportunityId",
                table: "GCrm_SolutionOffers");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_SolutionOffers_OpportunityId",
                table: "GCrm_SolutionOffers");

            migrationBuilder.DropColumn(
                name: "OpportunityId",
                table: "GCrm_SolutionOffers");

            migrationBuilder.DropColumn(
                name: "OpportunityTotalAmountEnum",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SolutionOffer",
                table: "GCrm_Opportunities");

            migrationBuilder.RenameColumn(
                name: "PotentialAmountEnum",
                table: "GCrm_Opportunities",
                newName: "CurrencyTypeEnum");

            migrationBuilder.AlterColumn<int>(
                name: "PotentialAmount",
                table: "GCrm_Opportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityTotalAmount",
                table: "GCrm_Opportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OpportunityLocation",
                table: "GCrm_Opportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ActionTaken",
                table: "GCrm_Opportunities",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SolutionOfferId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_SolutionOfferId",
                table: "GCrm_Opportunities",
                column: "SolutionOfferId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_GCrm_SolutionOffers_SolutionOfferId",
                table: "GCrm_Opportunities",
                column: "SolutionOfferId",
                principalTable: "GCrm_SolutionOffers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
