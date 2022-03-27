using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingTest.DataAccess.Migrations
{
    public partial class Third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Client_ClientId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employees_EmployeeIdd",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Projects_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Client_ClientId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Employees_EmployeId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectEmployee",
                table: "ProjectEmployee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_EmployeId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ClientId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeIdd",
                table: "ProjectEmployee");

            migrationBuilder.DropColumn(
                name: "MobilePhone",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "EmployeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeNumber",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ClientId",
                table: "Project",
                newName: "IX_Project_ClientId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "ProjectEmployee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Mobile",
                table: "Client",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameProject",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNum",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectEmployee",
                table: "ProjectEmployee",
                columns: new[] { "EmployeeId", "ProjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectEmployee",
                table: "ProjectEmployee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "NameProject",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmployeeNum",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Project_ClientId",
                table: "Projects",
                newName: "IX_Projects_ClientId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeIdd",
                table: "ProjectEmployee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MobilePhone",
                table: "Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectName",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeNumber",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectEmployee",
                table: "ProjectEmployee",
                columns: new[] { "EmployeeIdd", "ProjectId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_EmployeId",
                table: "Projects",
                column: "EmployeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ClientId",
                table: "Employees",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Client_ClientId",
                table: "Employees",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Employees_EmployeeIdd",
                table: "ProjectEmployee",
                column: "EmployeeIdd",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Projects_ProjectId",
                table: "ProjectEmployee",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Client_ClientId",
                table: "Projects",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Employees_EmployeId",
                table: "Projects",
                column: "EmployeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
