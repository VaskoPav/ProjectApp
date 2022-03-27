using Microsoft.EntityFrameworkCore.Migrations;

namespace CodingTest.DataAccess.Migrations
{
    public partial class Sixth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Project",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Project",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employee",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_EmployeeId",
                table: "Project",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Employee_EmployeeId",
                table: "Project",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Employee_EmployeeId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Employee_EmployeeId",
                table: "ProjectEmployee");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectEmployee_Project_ProjectId",
                table: "ProjectEmployee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_EmployeeId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

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
    }
}
