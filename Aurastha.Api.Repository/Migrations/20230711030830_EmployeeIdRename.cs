using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aurastha.Api.Repository.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeIdRename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "Employees",
                newName: "Employee_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Employee_Id",
                table: "Employees",
                newName: "EmployeeId");
        }
    }
}
