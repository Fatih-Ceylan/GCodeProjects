using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BaseProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_Base_GHR_GCard_Gcontrol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "MailCredantials");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "MailCredantials");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_SelfServices");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_SelfServices");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_RoleTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentSteps");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentProcessSteps");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentProcesses");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Recruiters");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Recruiters");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Payrolls");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Payrolls");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Notes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Notes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Locations");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Locations");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_LeaveTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Leaves");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Leaves");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobHistories");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobHistories");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicationStatusHistories");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicationStatuses");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplications");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplications");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicants");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobAdverts");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_JobAdvertPostedOn");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Employees");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Employees");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_EmployeeRoles");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_EducationInfos");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_DepartmentManagers");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GHR_Appellations");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GHR_Appellations");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_UserMainInfo");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_UserMainInfo");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_ShiftManagements");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_ShiftManagements");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_PasswordRemakes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_PasswordRemakes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_Locations");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_Locations");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_EntryExitManagements");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_EntryExitManagements");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_EmployeeTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_EmployeeTypes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_Employees");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_Employees");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_EmployeeLabels");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_EmployeeLabels");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_Department");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_Department");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_ApplicationSettings");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_ApplicationSettings");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GControl_Announcement");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GControl_Announcement");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Staffs");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Staffs");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_StaffFields");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_StaffFields");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_StaffContacts");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_StaffContacts");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_SocialMediaUrls");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_SocialMediaUrls");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_SocialMedias");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_SocialMedias");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_PhoneNumbers");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_PasswordRemakes");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_PasswordRemakes");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Orders");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Orders");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_OrderDetails");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_OrderDetails");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Invoices");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Invoices");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Ibans");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Ibans");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Fields");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Fields");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Cargos");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Cargos");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Cards");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Cards");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "GCard_Addresses");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "GCard_Addresses");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "CompanyLicenses");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "CompanyLicenses");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "AppUserLicenses");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "AppUserLicenses");

            migrationBuilder.DropColumn(
                name: "BaseProjectBranchId",
                table: "AppFiles");

            migrationBuilder.DropColumn(
                name: "BaseProjectCompanyId",
                table: "AppFiles");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "MailCredantials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "MailCredantials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_SelfServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_SelfServices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_RoleTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_RoleTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentSteps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentSteps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentProcessSteps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentProcessSteps",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_RecruitmentProcesses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_RecruitmentProcesses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Recruiters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Recruiters",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Payrolls",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Payrolls",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Notes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Notes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Locations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Locations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_LeaveTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_LeaveTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Leaves",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Leaves",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicationStatusHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicationStatusHistories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicationStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicationStatuses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplications",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobApplicants",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobApplicants",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobAdverts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobAdverts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_JobAdvertPostedOn",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_JobAdvertPostedOn",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_EmployeeRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_EmployeeRoles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_EducationInfos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_EducationInfos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_DepartmentManagers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_DepartmentManagers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GHR_Appellations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GHR_Appellations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_UserMainInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_UserMainInfo",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_ShiftManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_ShiftManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_PasswordRemakes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_PasswordRemakes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_Locations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_Locations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_EntryExitManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_EntryExitManagements",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_EmployeeTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_EmployeeTypes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_EmployeeLabels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_EmployeeLabels",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_Department",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_Department",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_ApplicationSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_ApplicationSettings",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GControl_Announcement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GControl_Announcement",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Staffs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Staffs",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_StaffFields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_StaffFields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_StaffContacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_StaffContacts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_SocialMediaUrls",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_SocialMediaUrls",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_SocialMedias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_SocialMedias",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_PhoneNumbers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_PhoneNumbers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_PasswordRemakes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_PasswordRemakes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_OrderDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_OrderDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Invoices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Invoices",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Ibans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Ibans",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Fields",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Cargos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Cargos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Cards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Cards",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "GCard_Addresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "GCard_Addresses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Districts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Districts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Departments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "CompanyLicenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "CompanyLicenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Companies",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Cities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Cities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "Branches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "Branches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "AppUserLicenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "AppUserLicenses",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectBranchId",
                table: "AppFiles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BaseProjectCompanyId",
                table: "AppFiles",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
