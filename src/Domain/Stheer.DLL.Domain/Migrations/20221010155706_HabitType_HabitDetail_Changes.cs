using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stheer.DLL.Domain.Migrations
{
    public partial class HabitType_HabitDetail_Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HabitType",
                table: "habitDetails",
                newName: "HabitTypeId");

            migrationBuilder.AddColumn<string>(
                name: "HabitTypeName",
                table: "habitTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HabitTypeName",
                table: "habitTypes");

            migrationBuilder.RenameColumn(
                name: "HabitTypeId",
                table: "habitDetails",
                newName: "HabitType");
        }
    }
}
