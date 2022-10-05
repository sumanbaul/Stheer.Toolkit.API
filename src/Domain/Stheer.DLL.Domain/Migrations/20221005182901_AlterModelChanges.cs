using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stheer.DLL.Domain.Migrations
{
    public partial class AlterModelChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HabitType",
                table: "habitDetails",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar2(150)");

            migrationBuilder.AlterColumn<string>(
                name: "HabitName",
                table: "habitDetails",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar2(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "habitDetails",
                type: "varchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar2(50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HabitType",
                table: "habitDetails",
                type: "varchar2(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "HabitName",
                table: "habitDetails",
                type: "varchar2(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "habitDetails",
                type: "varchar2(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)");
        }
    }
}
