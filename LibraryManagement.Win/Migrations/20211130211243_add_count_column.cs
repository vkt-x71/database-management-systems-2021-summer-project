using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Win.Migrations
{
    public partial class add_count_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookCount",
                table: "tbsettings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MagazineCount",
                table: "tbsettings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookCount",
                table: "tbsettings");

            migrationBuilder.DropColumn(
                name: "MagazineCount",
                table: "tbsettings");
        }
    }
}
