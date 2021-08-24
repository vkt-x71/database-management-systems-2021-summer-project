using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Win.Migrations
{
    public partial class count : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublicationCount",
                table: "tbsettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WriterCount",
                table: "tbsettings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublicationCount",
                table: "tbsettings");

            migrationBuilder.DropColumn(
                name: "WriterCount",
                table: "tbsettings");
        }
    }
}
