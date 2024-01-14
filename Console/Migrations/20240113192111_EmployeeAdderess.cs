using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Console.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeAdderess : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adderess",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adderess",
                table: "Employees");
        }
    }
}
