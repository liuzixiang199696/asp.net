using Microsoft.EntityFrameworkCore.Migrations;

namespace BLL.Migrations
{
    public partial class zx1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishSuggest",
                table: "suggests",
                newName: "PublishSuggestDateTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishSuggestDateTime",
                table: "suggests",
                newName: "PublishSuggest");
        }
    }
}
