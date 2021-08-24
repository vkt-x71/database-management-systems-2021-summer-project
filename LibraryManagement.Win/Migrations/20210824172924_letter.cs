using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagement.Win.Migrations
{
    public partial class letter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WriterCount",
                table: "tbsettings",
                newName: "writercount");

            migrationBuilder.RenameColumn(
                name: "PublicationCount",
                table: "tbsettings",
                newName: "publicationcount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "writercount",
                table: "tbsettings",
                newName: "WriterCount");

            migrationBuilder.RenameColumn(
                name: "publicationcount",
                table: "tbsettings",
                newName: "PublicationCount");
        }
    }
}
