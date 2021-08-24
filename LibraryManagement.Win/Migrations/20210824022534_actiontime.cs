using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Win.Migrations
{
    public partial class actiontime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "actionEndTime",
                table: "tbaction",
                type: "timestamp",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "actionFinalTime",
                table: "tbaction",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "actionTime",
                table: "tbaction",
                type: "timestamp",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "actionEndTime",
                table: "tbaction");

            migrationBuilder.DropColumn(
                name: "actionFinalTime",
                table: "tbaction");

            migrationBuilder.DropColumn(
                name: "actionTime",
                table: "tbaction");
        }
    }
}
