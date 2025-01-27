﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_31_Gcrm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropIndex(
                name: "IX_GCrm_Opportunities_SalesUserId1",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SalesUserId",
                table: "GCrm_Opportunities");

            migrationBuilder.DropColumn(
                name: "SalesUserId1",
                table: "GCrm_Opportunities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SalesUserId",
                table: "GCrm_Opportunities",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "SalesUserId1",
                table: "GCrm_Opportunities",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GCrm_Opportunities_SalesUserId1",
                table: "GCrm_Opportunities",
                column: "SalesUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GCrm_Opportunities_AspNetUsers_SalesUserId1",
                table: "GCrm_Opportunities",
                column: "SalesUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
