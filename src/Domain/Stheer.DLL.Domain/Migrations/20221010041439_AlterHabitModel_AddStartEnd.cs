﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stheer.DLL.Domain.Migrations
{
    public partial class AlterHabitModel_AddStartEnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "habitDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "habitDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "habitDetails");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "habitDetails");
        }
    }
}
