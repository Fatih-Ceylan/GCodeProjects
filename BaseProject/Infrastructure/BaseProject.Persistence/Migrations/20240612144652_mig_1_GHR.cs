using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1_GHR : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_SelfServices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_SelfServices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_SelfServices",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_RoleTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_RoleTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_RoleTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentProcesses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentProcesses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentProcesses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Recruiters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Recruiters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Recruiters",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Payrolls",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Payrolls",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Payrolls",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Notes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Notes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Notes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Locations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Locations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Locations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_LeaveTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_LeaveTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_LeaveTypes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Leaves",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Leaves",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Leaves",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobApplicationStatuses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobApplicationStatuses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicationStatuses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobApplications",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobApplicants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobApplicants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicants",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobAdverts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobAdverts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobAdverts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_JobAdvertPostedOn",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Employees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_EmployeeRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_EmployeeRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_EmployeeRoles",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_EducationInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_EducationInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_EducationInfos",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_DepartmentManagers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_DepartmentManagers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_DepartmentManagers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                table: "GHR_Appellations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DeletedByUserId",
                table: "GHR_Appellations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedByUserId",
                table: "GHR_Appellations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GHR_SelfServices_CreatedByUserId",
                table: "GHR_SelfServices",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_SelfServices_DeletedByUserId",
                table: "GHR_SelfServices",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_SelfServices_UpdatedByUserId",
                table: "GHR_SelfServices",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RoleTypes_CreatedByUserId",
                table: "GHR_RoleTypes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RoleTypes_DeletedByUserId",
                table: "GHR_RoleTypes",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RoleTypes_UpdatedByUserId",
                table: "GHR_RoleTypes",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentSteps_CreatedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentSteps_DeletedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentSteps_UpdatedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcessSteps_CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcessSteps_DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcessSteps_UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcesses_CreatedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcesses_DeletedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_RecruitmentProcesses_UpdatedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Recruiters_CreatedByUserId",
                table: "GHR_Recruiters",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Recruiters_DeletedByUserId",
                table: "GHR_Recruiters",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Recruiters_UpdatedByUserId",
                table: "GHR_Recruiters",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Payrolls_CreatedByUserId",
                table: "GHR_Payrolls",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Payrolls_DeletedByUserId",
                table: "GHR_Payrolls",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Payrolls_UpdatedByUserId",
                table: "GHR_Payrolls",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Notes_CreatedByUserId",
                table: "GHR_Notes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Notes_DeletedByUserId",
                table: "GHR_Notes",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Notes_UpdatedByUserId",
                table: "GHR_Notes",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Locations_CreatedByUserId",
                table: "GHR_Locations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Locations_DeletedByUserId",
                table: "GHR_Locations",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Locations_UpdatedByUserId",
                table: "GHR_Locations",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_LeaveTypes_CreatedByUserId",
                table: "GHR_LeaveTypes",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_LeaveTypes_DeletedByUserId",
                table: "GHR_LeaveTypes",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_LeaveTypes_UpdatedByUserId",
                table: "GHR_LeaveTypes",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Leaves_CreatedByUserId",
                table: "GHR_Leaves",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Leaves_DeletedByUserId",
                table: "GHR_Leaves",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Leaves_UpdatedByUserId",
                table: "GHR_Leaves",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobHistories_CreatedByUserId",
                table: "GHR_JobHistories",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobHistories_DeletedByUserId",
                table: "GHR_JobHistories",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobHistories_UpdatedByUserId",
                table: "GHR_JobHistories",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatusHistories_CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatusHistories_DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatusHistories_UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatuses_CreatedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatuses_DeletedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicationStatuses_UpdatedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_CreatedByUserId",
                table: "GHR_JobApplications",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_DeletedByUserId",
                table: "GHR_JobApplications",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplications_UpdatedByUserId",
                table: "GHR_JobApplications",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicants_CreatedByUserId",
                table: "GHR_JobApplicants",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicants_DeletedByUserId",
                table: "GHR_JobApplicants",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobApplicants_UpdatedByUserId",
                table: "GHR_JobApplicants",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdverts_CreatedByUserId",
                table: "GHR_JobAdverts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdverts_DeletedByUserId",
                table: "GHR_JobAdverts",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdverts_UpdatedByUserId",
                table: "GHR_JobAdverts",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdvertPostedOn_CreatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdvertPostedOn_DeletedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_JobAdvertPostedOn_UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Employees_CreatedByUserId",
                table: "GHR_Employees",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Employees_DeletedByUserId",
                table: "GHR_Employees",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Employees_UpdatedByUserId",
                table: "GHR_Employees",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EmployeeRoles_CreatedByUserId",
                table: "GHR_EmployeeRoles",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EmployeeRoles_DeletedByUserId",
                table: "GHR_EmployeeRoles",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EmployeeRoles_UpdatedByUserId",
                table: "GHR_EmployeeRoles",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EducationInfos_CreatedByUserId",
                table: "GHR_EducationInfos",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EducationInfos_DeletedByUserId",
                table: "GHR_EducationInfos",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_EducationInfos_UpdatedByUserId",
                table: "GHR_EducationInfos",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_DepartmentManagers_CreatedByUserId",
                table: "GHR_DepartmentManagers",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_DepartmentManagers_DeletedByUserId",
                table: "GHR_DepartmentManagers",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_DepartmentManagers_UpdatedByUserId",
                table: "GHR_DepartmentManagers",
                column: "UpdatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Appellations_CreatedByUserId",
                table: "GHR_Appellations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Appellations_DeletedByUserId",
                table: "GHR_Appellations",
                column: "DeletedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_GHR_Appellations_UpdatedByUserId",
                table: "GHR_Appellations",
                column: "UpdatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_CreatedByUserId",
                table: "GHR_Appellations",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_DeletedByUserId",
                table: "GHR_Appellations",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_UpdatedByUserId",
                table: "GHR_Appellations",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_CreatedByUserId",
                table: "GHR_DepartmentManagers",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_DeletedByUserId",
                table: "GHR_DepartmentManagers",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_UpdatedByUserId",
                table: "GHR_DepartmentManagers",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_CreatedByUserId",
                table: "GHR_EducationInfos",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_DeletedByUserId",
                table: "GHR_EducationInfos",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_UpdatedByUserId",
                table: "GHR_EducationInfos",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_CreatedByUserId",
                table: "GHR_EmployeeRoles",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_DeletedByUserId",
                table: "GHR_EmployeeRoles",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_UpdatedByUserId",
                table: "GHR_EmployeeRoles",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_CreatedByUserId",
                table: "GHR_Employees",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_DeletedByUserId",
                table: "GHR_Employees",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_UpdatedByUserId",
                table: "GHR_Employees",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_CreatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_DeletedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_CreatedByUserId",
                table: "GHR_JobAdverts",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_DeletedByUserId",
                table: "GHR_JobAdverts",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobAdverts",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicants",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicants",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicants",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplications",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplications",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplications",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicationStatuses",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_CreatedByUserId",
                table: "GHR_JobHistories",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_DeletedByUserId",
                table: "GHR_JobHistories",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobHistories",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_CreatedByUserId",
                table: "GHR_Leaves",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_DeletedByUserId",
                table: "GHR_Leaves",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_UpdatedByUserId",
                table: "GHR_Leaves",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_CreatedByUserId",
                table: "GHR_LeaveTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_DeletedByUserId",
                table: "GHR_LeaveTypes",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_UpdatedByUserId",
                table: "GHR_LeaveTypes",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_CreatedByUserId",
                table: "GHR_Locations",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_DeletedByUserId",
                table: "GHR_Locations",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_UpdatedByUserId",
                table: "GHR_Locations",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_CreatedByUserId",
                table: "GHR_Notes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_DeletedByUserId",
                table: "GHR_Notes",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_UpdatedByUserId",
                table: "GHR_Notes",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_CreatedByUserId",
                table: "GHR_Payrolls",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_DeletedByUserId",
                table: "GHR_Payrolls",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_UpdatedByUserId",
                table: "GHR_Payrolls",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_CreatedByUserId",
                table: "GHR_Recruiters",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_DeletedByUserId",
                table: "GHR_Recruiters",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_UpdatedByUserId",
                table: "GHR_Recruiters",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentProcesses",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentSteps",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_CreatedByUserId",
                table: "GHR_RoleTypes",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_DeletedByUserId",
                table: "GHR_RoleTypes",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_UpdatedByUserId",
                table: "GHR_RoleTypes",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_CreatedByUserId",
                table: "GHR_SelfServices",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_DeletedByUserId",
                table: "GHR_SelfServices",
                column: "DeletedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_UpdatedByUserId",
                table: "GHR_SelfServices",
                column: "UpdatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_CreatedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_DeletedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Appellations_AspNetUsers_UpdatedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_CreatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_DeletedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_DepartmentManagers_AspNetUsers_UpdatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_CreatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_DeletedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EducationInfos_AspNetUsers_UpdatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_CreatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_DeletedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_EmployeeRoles_AspNetUsers_UpdatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_CreatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_DeletedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Employees_AspNetUsers_UpdatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_CreatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_DeletedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdvertPostedOn_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_CreatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_DeletedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobAdverts_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicants_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplications_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatuses_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobApplicationStatusHistories_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_CreatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_DeletedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_JobHistories_AspNetUsers_UpdatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_CreatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_DeletedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Leaves_AspNetUsers_UpdatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_CreatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_DeletedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_LeaveTypes_AspNetUsers_UpdatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_CreatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_DeletedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Locations_AspNetUsers_UpdatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_CreatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_DeletedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Notes_AspNetUsers_UpdatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_CreatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_DeletedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Payrolls_AspNetUsers_UpdatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_CreatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_DeletedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_Recruiters_AspNetUsers_UpdatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcesses_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentProcessSteps_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_CreatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_DeletedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RecruitmentSteps_AspNetUsers_UpdatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_CreatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_DeletedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_RoleTypes_AspNetUsers_UpdatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_CreatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_DeletedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropForeignKey(
                name: "FK_GHR_SelfServices_AspNetUsers_UpdatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropIndex(
                name: "IX_GHR_SelfServices_CreatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropIndex(
                name: "IX_GHR_SelfServices_DeletedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropIndex(
                name: "IX_GHR_SelfServices_UpdatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RoleTypes_CreatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RoleTypes_DeletedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RoleTypes_UpdatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentSteps_CreatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentSteps_DeletedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentSteps_UpdatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcessSteps_CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcessSteps_DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcessSteps_UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcesses_CreatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcesses_DeletedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_RecruitmentProcesses_UpdatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Recruiters_CreatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Recruiters_DeletedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Recruiters_UpdatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Payrolls_CreatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Payrolls_DeletedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Payrolls_UpdatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Notes_CreatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Notes_DeletedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Notes_UpdatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Locations_CreatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Locations_DeletedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Locations_UpdatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropIndex(
                name: "IX_GHR_LeaveTypes_CreatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_LeaveTypes_DeletedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_LeaveTypes_UpdatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Leaves_CreatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Leaves_DeletedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Leaves_UpdatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobHistories_CreatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobHistories_DeletedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobHistories_UpdatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatusHistories_CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatusHistories_DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatusHistories_UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatuses_CreatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatuses_DeletedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicationStatuses_UpdatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplications_CreatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplications_DeletedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplications_UpdatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicants_CreatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicants_DeletedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobApplicants_UpdatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdverts_CreatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdverts_DeletedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdverts_UpdatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdvertPostedOn_CreatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdvertPostedOn_DeletedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropIndex(
                name: "IX_GHR_JobAdvertPostedOn_UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Employees_CreatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Employees_DeletedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Employees_UpdatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EmployeeRoles_CreatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EmployeeRoles_DeletedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EmployeeRoles_UpdatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EducationInfos_CreatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EducationInfos_DeletedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropIndex(
                name: "IX_GHR_EducationInfos_UpdatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropIndex(
                name: "IX_GHR_DepartmentManagers_CreatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropIndex(
                name: "IX_GHR_DepartmentManagers_DeletedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropIndex(
                name: "IX_GHR_DepartmentManagers_UpdatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Appellations_CreatedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Appellations_DeletedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropIndex(
                name: "IX_GHR_Appellations_UpdatedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_SelfServices");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Recruiters");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Payrolls");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Notes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Locations");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Leaves");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobHistories");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobApplications");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Employees");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropColumn(
                name: "DeletedByUserId",
                table: "GHR_Appellations");

            migrationBuilder.DropColumn(
                name: "UpdatedByUserId",
                table: "GHR_Appellations");
        }
    }
}
