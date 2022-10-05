using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stheer.DLL.Domain.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "habitDetails",
                columns: table => new
                {
                    HabitsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    HabitName = table.Column<string>(type: "varchar2(150)", nullable: false),
                    HabitType = table.Column<string>(type: "varchar2(150)", nullable: false),
                    IsCompleted = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "varchar2(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habitDetails", x => x.HabitsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "habitDetails");
        }
    }
}
